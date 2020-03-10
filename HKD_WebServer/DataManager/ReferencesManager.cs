using HKD_WebServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKD_WebServer.DataManager
{
    public class ReferencesManager
    {
        public object GetContractRequestTypesToJSON()
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.ContractRequestTypes
                                .Select(crt => new
                                {
                                    crt.Id,
                                    crt.Name,
                                    crt.Description,
                                    crt.VisibleStatus
                                })
                                .ToList();
            }
        }

        public object GetContractRequestTypesStatusVisibleToJSON()
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.ContractRequestTypesStatusVisible
                                .Select(crt => new
                                {
                                    crt.Id,
                                    crt.Discript
                                })
                                .ToList();
            }
        }

        public object GetContractScanExistsToJSON()
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.ContractScanExists
                                .Select(cse => new
                                {
                                    cse.Id,
                                    cse.Name
                                })
                                .ToList();
            }
        }

        public object GetContractRequestStatusesToJSON()
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.ContractRequestStatuses
                                .Select(crs => new
                                {
                                    crs.Id,
                                    crs.Name
                                })
                                .ToList();
            }
        }

        public object GetContractSignsToJSON()
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.ContractSigns
                                .Select(cs => new
                                {
                                    cs.Id,
                                    cs.Name
                                })
                                .ToList();
            }
        }

        public object GetOfficeCityToJSON()
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.OfficeCity
                                .Select(oc => new
                                {
                                    oc.Id,
                                    oc.Name
                                })
                                .ToList();
            }
        }

        public object GetOfficeAddressToJSON()
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.OfficeAddress
                                .Select(oa => new
                                {
                                    oa.Id,
                                    oa.City,
                                    oa.Address
                                })
                                .ToList();
            }
        }

        public object GetServiceTasksTypesTaskToJSON()
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.ServiceTasksTypesTask
                                .Select(sttt => new
                                {
                                    sttt.Id,
                                    sttt.Name
                                })
                                .ToList();
            }
        }

        public object GetServiceTasksStatusesTaskToJSON()
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.ServiceTasksStatusesTask
                                .Select(stst => new
                                {
                                    stst.Id,
                                    stst.Name
                                })
                                .ToList();
            }
        }
    }
}
