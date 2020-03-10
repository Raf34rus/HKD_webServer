using HKD_WebServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HKD_WebServer.DataManager.Exceptions;

namespace HKD_WebServer.DataManager
{
    public class ContractMassManager
    {
        public object GetContractMassListToJSON(FiltratorContractListMass _flt)
        {
            ScanStoreContext ssContext = new ScanStoreContext();

            var cons = _flt.resIds.Join(ssContext.Contracts
                                                 .Include(con => con.ContractScans)
                                                 .Include(con => con.Cession)
                                                 .Include(con => con.Cession.Partner)
                                                 .Where(con=> _flt.resIds.Contains(con.Id)),
                                        ri => ri,
                                        con => con.Id,
                                        (ri, con) => con
                                        )
                                        .Include(con => con.ContractScans)
                                        .Include(con => con.Cession)
                                        .Skip(_flt.model.skip).Take(_flt.model.take);

            //var lst = cons.Count();

            var cc = cons
                .Select(con => new
                {
                    con.Id,
                    con.IdPkb,
                    con.IdPristav,
                    con.DebtNumber,
                    con.DebtorFio,
                    con.DebtDate,
                    auditing = con.Auditing,
                    avtocredit = con.Avtocredit,
                    cessionName = con.Cession.Name,
                    cessionDate = con.Cession.Date,
                    partnerName = con.Cession.Partner.Name,
                        contractScans = con.ContractScans.Select(cs => new
                        {
                            id = cs.Id,
                            csType = cs.CsType,
                            keeper = cs.Keeper,
                            city = cs.City,
                            party = cs.Party,
                            box = cs.Box,
                            folder = cs.Folder,
                            fileName = cs.FileName,
                            exist = cs.ExistDocument
                        })
                });
            return cc;
        }
    }
    public class ContractsMassViewModel
    {

        public int[] checkedPartners { get; set; } // выбранные значения в выпадающем списке партнеров
        public int[] checkedCessions { get; set; } // выбранные значения в выпадающем списке цессий
        public int searchExistScan { get; set; } // Наличие сканов
        public int searchType { get; set; } // Параметр поиска
        public string searchValue { get; set; } // Значение поиска

        public string searchSingleValue { get; set; } // Значение поиска
        public bool isExistError { get; set; } // флаг ошибки поиска
        public string msg { get; set; } // выводимое сообщение
        public int skip { get; set; }
        public int take { get; set; }

        public ContractsMassViewModel()
        {
            searchType = 0;
            searchExistScan = 0;
            isExistError = true;
            checkedPartners = new int[0];
            checkedCessions = new int[0];
            msg = "Поиск и печать ограничены 500 кредитными досье. При поиске более 500 записей печать недоступна.";
        }
        public bool IsEmpty() // ничего не введено в поиск
        {
            return (checkedPartners == null || checkedPartners.Count() == 0)
                && (checkedCessions == null || checkedCessions.Count() == 0)
                && (string.IsNullOrEmpty(searchValue))
                && (string.IsNullOrEmpty(searchSingleValue));
        }
    }

    public class FiltratorContractListMass
    {

        public static readonly Dictionary<int, string> searchType = new Dictionary<int, string>()
            {
                { 0, "по ID Пристав" },
                { 1, "по ID ПКБ" },
                { 2, "по ID ХКД" },
                { 3, "по ФИО (Строгое соответствие)"},
                { 4, "по Номеру договора (Строгое соответствие)"},
                { 5, "по ФИО (Не строгое соответствие)" },
                { 6, "по Номеру договора (Не строгое соответствие)" }
            };

        public static readonly Dictionary<int, string> searchExistScan = new Dictionary<int, string>()
            {
                { 0, "Все" },
                { 1, "Только без сканов" },
                { 2, "Только со сканами" }
            };

        public ContractsMassViewModel model;
        private IQueryable<Cessions> cessionList = null;
        private IQueryable<Contracts> contractsList = null;
        private List<Contracts> sortContractsList;
        private long[] arrInt; // массив чисел для поиска
        private string[] arrStr; // массив строк для поиска
        private string str; //одиночная строка поиска
        public Comparer<Contracts> ContractComparer; // фильтрация List
        ScanStoreContext ssContext;
        //public IQueryable<Contracts> resultContractsList;
        public IQueryable<int> resIds;

        public FiltratorContractListMass(ContractsMassViewModel _model)
        {
            if (_model == null)
                throw new Exception("Неопределены все обязательные параметры");
            ssContext = new ScanStoreContext();
            //resultContractsList = null;
            model = _model;
            contractsList = ssContext.Contracts.AsNoTracking().AsQueryable<Contracts>();
            sortContractsList = new List<Contracts>();
        }

        #region PrepWhere 

        private void PrepIdPristav()
        {
            arrInt = GetValueNumbers();
            if (arrInt.Count() > 0)
            {
                contractsList = contractsList.Where(c => arrInt.Contains(c.IdPristav.Value));
                ContractComparer = Comparer<Contracts>.Create((x, y) => { return Array.IndexOf(arrInt, x.IdPristav.Value) - Array.IndexOf(arrInt, y.IdPristav.Value); });
            }
        }
        private void PrepIdPKB()
        {
            arrInt = GetValueNumbers();
            if (arrInt.Count() > 0)
            {
                contractsList = contractsList.Where(c => arrInt.Contains(c.IdPkb));
                ContractComparer = Comparer<Contracts>.Create((x, y) => { return Array.IndexOf(arrInt, x.IdPkb) - Array.IndexOf(arrInt, y.IdPkb); });
            }
        }
        private void PrepIdHKD()
        {
            arrInt = GetValueNumbers();
            if (arrInt.Count() > 0)
            {
                contractsList = contractsList.Where(c => arrInt.Contains(c.Id));
                ContractComparer = Comparer<Contracts>.Create((x, y) => { return Array.IndexOf(arrInt, x.Id) - Array.IndexOf(arrInt, y.Id); });
            }
        }
        private void PrepFIOMass()
        {
            arrStr = GetValueStrings();
            if (arrStr.Count() > 0)
            {
                contractsList = contractsList.Where(c => arrStr.Contains(c.DebtorFio));
                ContractComparer = Comparer<Contracts>.Create((x, y) => { return Array.IndexOf(arrStr, x.DebtorFio.ToUpper().Trim()) - Array.IndexOf(arrStr, y.DebtorFio.ToUpper().Trim()); });
            }
        }
        private void PrepDebtMass()
        {
            arrStr = GetValueStrings();
            if (arrStr.Count() > 0)
            {
                contractsList = contractsList.Where(c => arrStr.Contains(c.DebtNumber));
                ContractComparer = Comparer<Contracts>.Create((x, y) => { return Array.IndexOf<string>(arrStr, x.DebtNumber.ToUpper().Trim()) - Array.IndexOf<string>(arrStr, y.DebtNumber.ToUpper().Trim()); });
            }
        }
        private void PrepFIOSingle()
        {
            str = GetSingleValue();
            var lst = new List<string> { str };
            if (!String.IsNullOrEmpty(str))
                contractsList = contractsList.Where(c => lst.Any(x => c.DebtorFio.Contains(x)));

        }
        private void PrepDebtSingle()
        {
            str = GetSingleValue();
            var lst = new List<string> { str };
            if (!String.IsNullOrEmpty(str))
                contractsList = contractsList.Where(c => lst.Any(x => c.DebtNumber.Contains(x)));
        }
        private void PrepExistScan() //условие на существование скана
        {
            switch (model.searchExistScan)
            {
                case 0:
                    break;
                case 1:
                    {
                        contractsList = contractsList.Where(c => c.ContractScans.Any() == false);
                        break;
                    }
                case 2:
                    {
                        contractsList = contractsList.Where(c => c.ContractScans.Any() == true);
                        break;
                    }
                default:
                    throw new Exception("Неопределен searchExistScan для ContractsMassViewModel");
            }
        }
        private void PrepPartnerList()
        {
            if (model.checkedPartners.Count() > 0)
            {
                cessionList = ssContext.Cessions.Where(c => model.checkedPartners.Contains(c.Partner.Id)); //.OrderBy(c => c.date);
                contractsList = contractsList.Join(cessionList, a => a.Cession.Id, b => b.Id, (a, b) => a);
            }
        }
        private void PrepCessionList() //Условие на цессии и партнера
        {
            if (model.checkedCessions.Count() > 0) // если выбрана цессия, добавлять условие по партнеру не имеет смысла, т.к. он связан с Contract через цессию
            {
                cessionList = ssContext.Cessions.Where(c => model.checkedCessions.Contains(c.Id)); //.OrderBy(c => c.date);
                contractsList = contractsList.Join(cessionList, a => a.Cession.Id, b => b.Id, (a, b) => a);
            }
        }
        private long[] GetValueNumbers() // получение значения поиска как массив чисел
        {
            if (!string.IsNullOrEmpty(model.searchValue))
                arrInt = model.searchValue.Split(Consts.SeparatorN, StringSplitOptions.RemoveEmptyEntries).Where(i => Int64.TryParse(i, out long validNumber)).Select(Int64.Parse).ToArray(); //(s => Int64.TryParse(s, out long n) ? n : -1).ToArray();
            else
                arrInt = new long[0];
            return arrInt;
        }
        private string[] GetValueStrings() //  получение значения поиска как массив строк
        {
            if (!string.IsNullOrEmpty(model.searchValue))
            {
                List<string> arrStrSearchValue = new List<string>();
                var arrStrSearchValuetmp = model.searchValue.ToUpper().Trim(Consts.UserInputTrim).Split(Consts.SeparatorN, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();
                if (arrStrSearchValue.Count() > 500)
                    throw new ExceptionFiltrator("Введено более 500 значений для поиска");
                foreach (var str in arrStrSearchValuetmp)
                {
                    arrStrSearchValue.Add(str.Trim());
                }
                arrStr = arrStrSearchValue.ToArray();
            }
            else
                arrStr = new string[0];
            return arrStr;
        }
        private string GetSingleValue() //  получение значения поиска как одиночную строку
        {
            str = String.Empty;
            if (!String.IsNullOrEmpty(model.searchSingleValue))
            {
                str = model.searchSingleValue.Trim();
                if (str.Length > 200)
                    throw new ExceptionFiltrator("Введено более 200 символов");
            }
            return str;
        }
        #endregion
        private IQueryable<int> Exec()
        {
            //если не было наложено ниодного валидного условия:
            if (contractsList == ssContext.Contracts.AsQueryable<Contracts>())
                return null;

            // Выкачиваем данные из БД для сортировки:
            if (ContractComparer != null)
            {
                sortContractsList = contractsList.ToList();
                sortContractsList.Sort(ContractComparer);
                return sortContractsList.Select(scl => scl.Id).AsQueryable();
            }
            else // без сортировки, просто запрос к БД:
            {
                return contractsList.Select(cl => cl.Id).AsQueryable();
            }
        }

        private void Init()
        {
            ContractComparer = null;
            PrepExistScan();
            PrepPartnerList();
            PrepCessionList();
            switch (model.searchType)
            {
                case 0: //по ID Пристав
                    {
                        PrepIdPristav();
                        break;
                    }
                case 1: //по ID ПКБ
                    {
                        PrepIdPKB();
                        break;
                    }
                case 2: //по ID ХКД
                    {
                        PrepIdHKD();
                        break;
                    }
                case 3: //по ФИО (Строгое соответствие)
                    {
                        PrepFIOMass();
                        break;
                    }
                case 4: //по Номеру договора (Строгое соответствие)
                    {
                        PrepDebtMass();
                        break;
                    }
                case 5: //по ФИО (Не строгое соответствие)
                    {
                        PrepFIOSingle();
                        break;
                    }
                case 6: //по Номеру договора (Не строгое соответствие)                
                    {
                        PrepDebtSingle();
                        break;
                    }
                default:
                    throw new Exception("Неопределен searchType для ContractsMassViewModel");
            }
        }


        public void GetContractList()
        {
            try
            {
                if (!model.IsEmpty())
                {
                    Init();
                    resIds = Exec();
                    model.isExistError = false;
                }
                else
                {
                    model.isExistError = true;
                    model.msg = string.Format("Не заданы папаметры поиска");
                }

            }
            catch (ExceptionFiltrator ef)
            {
                model.isExistError = true;
                model.msg = ef.Message;
            }
            catch (Exception ex)
            {
                model.isExistError = true;
                model.msg = string.Format("Необработнная ошибка в классе FiltratorContractListMass, с текстом: {0}", ex.Message);
                //throw new Exception(string.Format("Необработнная ошибка в классе FiltratorContractListMass, с текстом: {0}", ex.Message));
            }
            //return resultContractsList;
        }
    }

}
