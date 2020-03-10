using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class ContractRequestTypes
    {
        public ContractRequestTypes()
        {
            ContractRequess = new HashSet<ContractRequess>();
            ContractScans = new HashSet<ContractScans>();
            ContractsLocations = new HashSet<ContractsLocations>();
            LogInsContractScans = new HashSet<LogInsContractScans>();
            LogInsRequests = new HashSet<LogInsRequests>();
            LogUpdContractScansLocations = new HashSet<LogUpdContractScansLocations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int VisibleStatus { get; set; }

        public ContractRequestTypesStatusVisible VisibleStatusNavigation { get; set; }
        public ICollection<ContractRequess> ContractRequess { get; set; }
        public ICollection<ContractScans> ContractScans { get; set; }
        public ICollection<ContractsLocations> ContractsLocations { get; set; }
        public ICollection<LogInsContractScans> LogInsContractScans { get; set; }
        public ICollection<LogInsRequests> LogInsRequests { get; set; }
        public ICollection<LogUpdContractScansLocations> LogUpdContractScansLocations { get; set; }
    }
}
