using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class StatusesCopy
    {
        public StatusesCopy()
        {
            CessionScans = new HashSet<CessionScans>();
            ContractScans = new HashSet<ContractScans>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CessionScans> CessionScans { get; set; }
        public ICollection<ContractScans> ContractScans { get; set; }
    }
}
