using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class OfficeAddress
    {
        public OfficeAddress()
        {
            ContractRequess = new HashSet<ContractRequess>();
        }

        public int Id { get; set; }
        public int City { get; set; }
        public string Address { get; set; }

        public OfficeCity CityNavigation { get; set; }
        public ICollection<ContractRequess> ContractRequess { get; set; }
    }
}
