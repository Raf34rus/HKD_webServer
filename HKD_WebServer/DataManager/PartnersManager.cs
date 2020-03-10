using HKD_WebServer.Common;
using HKD_WebServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKD_WebServer.DataManager
{
    public class PartnersManager
    {
        public object GetPartnersListToJSON()
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.Partners
                                .Select(p => new
                                {
                                    p.Id,
                                    p.Name
                                })
                                .ToList();
            }
        }

        public object GetPartnerInfoToJSON(int _id)
        {
            using (var ssContext = new ScanStoreContext())
            {
                var cessionsPartner = ssContext.Cessions
                                               .Where(c => c.PartnerId == _id)
                                               .Include(c => c.CessionScans)
                                               .Include(c => c.Contracts);

                int cessionsCount = cessionsPartner.Count();

                int contractsCount = cessionsPartner.Sum(c => c.Contracts.Count());

                int queryCount = ssContext.ContractRequess.Count(c => c.Contract.Cession.Partner.Id == _id);

                var cessionsStatisticsPartner = cessionsPartner.Select(c => new
                {
                    c.Id,
                    c.Name,
                    cessionScansCount = c.CessionScans.Count,
                    contractsCount = c.Contracts.Count,
                    contractsCountWithoutScans = c.Contracts.Count(con => !con.ContractScans.Any())
                }).ToList();

                return ssContext.Partners
                                .Where(p => p.Id == _id)
                                .Select(c => new
                                {
                                    c.Id,
                                    c.Name,
                                    cessionsCount,
                                    contractsCount,
                                    queryCount,
                                    cessionsStatisticsPartner
                                })
                                .SingleOrDefault();
            }
        }

        public bool IsValidInData(Partners _partner)
        {
            bool res = false;
            using (var ssContext = new ScanStoreContext())
            {
                var fPartn = ssContext.Partners.SingleOrDefault(p => p.Name == _partner.Name);
                if (_partner != null)
                {
                    if (_partner.Name != null && _partner.Name != "" && fPartn == null)
                    {
                        res = true;
                    }
                }
                return res;
            }

        }

    }
}
