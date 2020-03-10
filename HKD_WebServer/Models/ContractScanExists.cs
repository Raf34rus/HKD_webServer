using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class ContractScanExists
    {
        public ContractScanExists()
        {
            ContractScans = new HashSet<ContractScans>();
            LogInsContractScans = new HashSet<LogInsContractScans>();
            LogUpdContractScansLocations = new HashSet<LogUpdContractScansLocations>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public ICollection<ContractScans> ContractScans { get; set; }
        public ICollection<LogInsContractScans> LogInsContractScans { get; set; }
        public ICollection<LogUpdContractScansLocations> LogUpdContractScansLocations { get; set; }
    }
}
