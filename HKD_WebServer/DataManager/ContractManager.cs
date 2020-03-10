using HKD_WebServer.Common;
using HKD_WebServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HKD_WebServer.DataManager.Exceptions;

namespace HKD_WebServer.DataManager
{
    public class ContractManager
    {
        public object GetContractInfoToJSON(int _id)
        {
            using (var ssContext = new ScanStoreContext())
            {

                return ssContext.Contracts
                                .Where(con => con.Id == _id)
                                .Include(con => con.ContractScans)
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
                                }).SingleOrDefault();
            }
        }


    }
}
