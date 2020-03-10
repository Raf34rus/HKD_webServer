using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class ContractsInRequest
    {
        public int Id { get; set; }
        public int ContractRequessId { get; set; }
        public int OutsideRequessId { get; set; }

        public ContractRequess ContractRequess { get; set; }
        public OutsideRequess OutsideRequess { get; set; }
    }
}
