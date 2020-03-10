using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class ContractRequestStatuses
    {
        public ContractRequestStatuses()
        {
            ContractRequess = new HashSet<ContractRequess>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ContractRequess> ContractRequess { get; set; }
    }
}
