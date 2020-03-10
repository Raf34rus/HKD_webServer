using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class ContractRequestTypesStatusVisible
    {
        public ContractRequestTypesStatusVisible()
        {
            ContractRequestTypes = new HashSet<ContractRequestTypes>();
        }

        public int Id { get; set; }
        public string Discript { get; set; }

        public ICollection<ContractRequestTypes> ContractRequestTypes { get; set; }
    }
}
