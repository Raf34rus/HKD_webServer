using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class OfficeCity
    {
        public OfficeCity()
        {
            OfficeAddress = new HashSet<OfficeAddress>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<OfficeAddress> OfficeAddress { get; set; }
    }
}
