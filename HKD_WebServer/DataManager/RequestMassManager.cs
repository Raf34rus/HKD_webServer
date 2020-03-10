using HKD_WebServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HKD_WebServer.DataManager.Exceptions;

namespace HKD_WebServer.DataManager
{
    public class RequestMassManager
    {
        public object GetRequestMassListToJSON(FiltratorRequestListMass _frlm)
        {
            ScanStoreContext ssContext = new ScanStoreContext();

            var conr = _frlm.resIds.Join(ssContext.ContractRequess
                                                  .Include(cr => cr.Contract)
                                                  .Include(cr => cr.Contract.Cession)
                                                  .Include(cr => cr.Contract.Cession.Partner)
                                                  .Where(cr => _frlm.resIds.Contains(cr.Id)),
                                         ri => ri,
                                         cr => cr.Id,
                                         (ri, cr) => cr
                                         )
                                         .Include(cr => cr.Contract)
                                         .Include(cr => cr.Contract.Cession)
                                         .Skip(_frlm.model.skip).Take(_frlm.model.take);

            var cc = conr
                .Select(cr => new
                {
                    requestId = cr.Id,
                    cr.Contract.Id,
                    cr.Contract.IdPkb,
                    cr.Contract.IdPristav,
                    cr.Contract.DebtNumber,
                    cr.Contract.DebtorFio,
                    cr.RequestDate,
                    cr.ReqStatus,
                    cr.ReqType,

                    cessionName = cr.Contract.Cession.Name,
                    partnerName = cr.Contract.Cession.Partner.Name,
                });
            return cc;
        }
    }

    public class RequestMassViewModel
    {
        public int[] checkedPartners { get; set; } // выбранные значения в выпадающем списке партнеров
        public int[] checkedCessions { get; set; } // выбранные значения в выпадающем списке цессий
        public int[] checkedType { get; set; } // выбранные значения в выпадающем списке цессий
        public int[] checkedStatus { get; set; } // выбранные значения в выпадающем списке цессий
        public string searchValueKeeper { get; set; }
        public string searchValueCity { get; set; }
        public string searchValueParty { get; set; }
        public string searchValueBox { get; set; }
        public int searchType { get; set; }
        public string searchValue { get; set; }
        public string searchSingleValue { get; set; }
        public bool isExistError { get; set; } // флаг ошибки поиска
        public string msg { get; set; } // выводимое сообщение
        public string userName { get; set; }

        public int skip { get; set; }
        public int take { get; set; }

        public RequestMassViewModel()
        {
            searchType = 0;
            isExistError = true;
            checkedPartners = new int[0];
            checkedCessions = new int[0];
            checkedType = new int[0];
            checkedStatus = new int[0];

            msg = "Поиск запросов";
        }
        public bool IsEmpty() // ничего не введено в поиск
        {
            return (checkedPartners == null || checkedPartners.Count() == 0)
                && (checkedCessions == null || checkedCessions.Count() == 0)
                && (checkedType == null || checkedType.Count() == 0)
                && (checkedStatus == null || checkedStatus.Count() == 0)
                && string.IsNullOrEmpty(searchValue)
                && string.IsNullOrEmpty(userName)
                && string.IsNullOrEmpty(searchSingleValue)
                && string.IsNullOrEmpty(searchValueBox)
                && string.IsNullOrEmpty(searchValueCity)
                && string.IsNullOrEmpty(searchValueKeeper)
                && string.IsNullOrEmpty(searchValueParty)
                ;
        }
    }

    public class FiltratorRequestListMass
    {
        //

        public static readonly Dictionary<int, string> searchType = new Dictionary<int, string>()
        {
            { 0, "по ID Пристав" },
            { 1, "по ID ПКБ" },
            { 2, "по ID ХКД" },
            { 3, "по ID Запроса" },
            { 4, "по ФИО (Строгое соответствие)"},
            { 5, "по Номеру договора (Строгое соответствие)"},
            { 6, "по ФИО (Не строгое соответствие)" },
            { 7, "по Номеру договора (Не строгое соответствие)" }
        };
        public static readonly Dictionary<int, string> searchExistScan = new Dictionary<int, string>()
        {
            { 0, "Все" },
            { 1, "Только без сканов" },
            { 2, "Только со сканами" }
        };


        public RequestMassViewModel model;

        private IQueryable<Cessions> cessionList = null;
        private IQueryable<ContractRequess> RequestsList = null;
        private List<ContractRequess> sortRequestList;
        private long[] arrInt; // массив чисел для поиска
        private string[] arrStr; // массив строк для поиска
        private string str; //одиночная строка поиска
        private Comparer<ContractRequess> RequestComparer; // фильтрация List
        ScanStoreContext ssContext;
        public IQueryable<int> resIds;

        public FiltratorRequestListMass(RequestMassViewModel _model)
        {
            if (_model == null)
                throw new Exception("Неопределены все обязательные параметры");
            ssContext = new ScanStoreContext();
            //resultContractsList = null;
            model = _model;
            RequestsList = ssContext.ContractRequess.AsNoTracking().AsQueryable<ContractRequess>();
            sortRequestList = new List<ContractRequess>();
        }

        #region PrepWhere 

        private void PrepIdPristav()
        {
            arrInt = GetValueNumbers();
            if (arrInt.Count() > 0)
            {
                RequestsList = RequestsList.Where(c => arrInt.Contains(c.Contract.IdPristav.Value));
                RequestComparer = Comparer<ContractRequess>.Create((x, y) => { return Array.IndexOf(arrInt, x.Contract.IdPristav.Value) - Array.IndexOf(arrInt, y.Contract.IdPristav.Value); });
            }
        }
        private void PrepIdPKB()
        {
            arrInt = GetValueNumbers();
            if (arrInt.Count() > 0)
            {
                RequestsList = RequestsList.Where(c => arrInt.Contains(c.Contract.IdPkb));
                RequestComparer = Comparer<ContractRequess>.Create((x, y) => { return Array.IndexOf(arrInt, x.Contract.IdPkb) - Array.IndexOf(arrInt, y.Contract.IdPkb); });
            }
        }
        private void PrepIdHKD()
        {
            arrInt = GetValueNumbers();
            if (arrInt.Count() > 0)
            {
                RequestsList = RequestsList.Where(c => arrInt.Contains(c.Contract.Id));
                RequestComparer = Comparer<ContractRequess>.Create((x, y) => { return Array.IndexOf(arrInt, x.Contract.Id) - Array.IndexOf(arrInt, y.Contract.Id); });
            }
        }
        private void PrepIdRequest()
        {
            arrInt = GetValueNumbers();
            if (arrInt.Count() > 0)
            {
                RequestsList = RequestsList.Where(c => arrInt.Contains(c.Id));
                RequestComparer = Comparer<ContractRequess>.Create((x, y) => { return Array.IndexOf(arrInt, x.Id) - Array.IndexOf(arrInt, y.Id); });
            }
        }
        private void PrepFIOMass()
        {
            arrStr = GetValueStrings();
            if (arrStr.Count() > 0)
            {
                RequestsList = RequestsList.Where(c => arrStr.Contains(c.Contract.DebtorFio));
                RequestComparer = Comparer<ContractRequess>.Create((x, y) => { return Array.IndexOf(arrStr, x.Contract.DebtorFio.ToUpper().Trim()) - Array.IndexOf(arrStr, y.Contract.DebtorFio.ToUpper().Trim()); });
            }
        }
        private void PrepDebtMass()
        {
            arrStr = GetValueStrings();
            if (arrStr.Count() > 0)
            {
                RequestsList = RequestsList.Where(c => arrStr.Contains(c.Contract.DebtNumber));
                RequestComparer = Comparer<ContractRequess>.Create((x, y) => { return Array.IndexOf<string>(arrStr, x.Contract.DebtNumber.ToUpper().Trim()) - Array.IndexOf<string>(arrStr, y.Contract.DebtNumber.ToUpper().Trim()); });
            }
        }
        private void PrepFIOSingle()
        {
            str = GetSingleValue();
            var lst = new List<string> { str };
            if (!String.IsNullOrEmpty(str))
                RequestsList = RequestsList.Where(c => lst.Any(x => c.Contract.DebtorFio.Contains(x)));

        }
        private void PrepDebtSingle()
        {
            str = GetSingleValue();
            var lst = new List<string> { str };
            if (!String.IsNullOrEmpty(str))
                RequestsList = RequestsList.Where(c => lst.Any(x => c.Contract.DebtNumber.Contains(x)));
        }
        private void PrepExistScan() //условие на существование скана
        { 
        }
        private void PrepUser()
        {
            if (!String.IsNullOrEmpty(model.userName))
            {
                RequestsList = RequestsList.Where(c => c.RequestUser == model.userName); //.OrderBy(c => c.date);
            }
        }
        private void PrepStatus()
        {
            if (model.checkedStatus.Count() > 0)
            {
                RequestsList = RequestsList.Where(c => model.checkedStatus.Contains(c.ReqStatus)); //.OrderBy(c => c.date);
            }
        }
        private void PrepType()
        {
            if (model.checkedType.Count() > 0)
            {
                RequestsList = RequestsList.Where(c => model.checkedType.Contains(c.ReqType)); //.OrderBy(c => c.date);
            }
        }
        private void PrepLocation()
        {
            if (model.searchValueKeeper?.Length > 0)
            {
                RequestsList = RequestsList.Where(c => c.Contract.ContractScans.Any(k => k.Keeper == model.searchValueKeeper)); //.OrderBy(c => c.date);
            }
            if (model.searchValueCity?.Length > 0)
            {
                RequestsList = RequestsList.Where(c => c.Contract.ContractScans.Any(k => k.City == model.searchValueCity)); //.OrderBy(c => c.date);
            }
            if (model.searchValueBox?.Length > 0)
            {
                RequestsList = RequestsList.Where(c => c.Contract.ContractScans.Any(k => k.Box == model.searchValueBox)); //.OrderBy(c => c.date);
            }
            if (model.searchValueParty?.Length > 0)
            {
                RequestsList = RequestsList.Where(c => c.Contract.ContractScans.Any(k => k.Party == model.searchValueParty)); //.OrderBy(c => c.date);
            }
        }
        private void PrepPartnerList()
        {
            if (model.checkedPartners.Count() > 0)
            {
                cessionList = ssContext.Cessions.Where(c => model.checkedPartners.Contains(c.Partner.Id)); //.OrderBy(c => c.date);
                //contractsList = contractsList.Where(cl => cessionList.Contains(cl.Cession));
                RequestsList = RequestsList.Join(cessionList, a => a.Contract.Cession.Id, b => b.Id, (a, b) => a);
            }
        }
        private void PrepCessionList() //Условие на цессии и партнера
        {
            if (model.checkedCessions.Count() > 0) // если выбрана цессия, добавлять условие по партнеру не имеет смысла, т.к. он связан с Contract через цессию
            {
                cessionList = ssContext.Cessions.Where(c => model.checkedCessions.Contains(c.Id)); //.OrderBy(c => c.date);
                //contractsList = contractsList.Where(cl => cessionList.Contains(cl.Cession));
                RequestsList = RequestsList.Join(cessionList, a => a.Contract.Cession.Id, b => b.Id, (a, b) => a);
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
            if (RequestsList == ssContext.ContractRequess.AsQueryable<ContractRequess>()) //если не было наложено ниодного валидного условия 
                return null;
            else // без сортировки, просто запрос к БД:
            {
                return RequestsList.Select(cl => cl.Id).AsQueryable();
            }
        }

        private void Init()
        {
            RequestComparer = null;
            PrepUser();
            PrepExistScan();
            PrepPartnerList();
            PrepCessionList();
            PrepStatus();
            PrepType();
            PrepLocation();
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
                case 3: //по ID запроса
                    {
                        PrepIdRequest();
                        break;
                    }
                case 4: //по ФИО (Строгое соответствие)
                    {
                        PrepFIOMass();
                        break;
                    }
                case 5: //по Номеру договора (Строгое соответствие)
                    {
                        PrepDebtMass();
                        break;
                    }
                case 6: //по ФИО (Не строгое соответствие)
                    {
                        PrepFIOSingle();
                        break;
                    }
                case 7: //по Номеру договора (Не строгое соответствие)                
                    {
                        PrepDebtSingle();
                        break;
                    }
                default:
                    throw new Exception("Неопределен searchType для ContractsMassViewModel");
            }
        }

        public void GetRequestList()
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
                model.msg = string.Format("Необработнная ошибка в классе FiltratorRequestsListMass, с текстом: {0}", ex.Message);
            }

        }
    }
}
