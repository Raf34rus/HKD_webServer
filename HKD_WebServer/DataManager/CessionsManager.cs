using HKD_WebServer.Common;
using HKD_WebServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKD_WebServer.DataManager
{
    public class CessionsManager
    {
        public object GetCessionsListToJSON()
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.Cessions.Select(cess => new { cess.Id,
                                                                cess.Name,
                                                                cess.Date,
                                                                cess.PartnerId
                                                             }).ToList();
            }
        }

        public object GetCessionInfoToJSON(int _id)
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.Cessions
                                .Where(cess => cess.Id == _id)
                                .Include(cess => cess.CessionScans)
                                .Include(cess => cess.Partner)
                                .Include(cess => cess.Contracts)
                                .Select(cess => new
                                {
                                    cess.Id,
                                    cess.Name,
                                    cess.Date,
                                    partnerName = cess.Partner.Name,
                                    cess.CommitDate,
                                    contractCount = cess.Contracts.Count(),
                                    cessionScans = cess.CessionScans.Select(cs => new
                                    {
                                        cs.Id,
                                        cs.FileName,
                                        cs.Type,
                                        cs.Size
                                    })
                                }).SingleOrDefault();
            }
        }

        public bool IsValidInData(Cessions _cession)
        {
            using (var ssContext = new ScanStoreContext())
            {
                bool res = false;
                var fCess = ssContext.Cessions.SingleOrDefault(c => c.Name == _cession.Name);
                var fPartn = ssContext.Partners.SingleOrDefault(p => p.Id == _cession.PartnerId);

                if (_cession != null)
                {
                    if (_cession.Name != null && _cession.Name != "" && _cession.Date != null && fCess == null && fPartn != null)
                    {
                        res = true;
                    }
                }

                return res;
            }
        }
    }
}
