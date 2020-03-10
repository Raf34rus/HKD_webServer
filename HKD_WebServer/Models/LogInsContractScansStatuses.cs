using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class LogInsContractScansStatuses
    {
        public LogInsContractScansStatuses()
        {
            LogInsContractScans = new HashSet<LogInsContractScans>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<LogInsContractScans> LogInsContractScans { get; set; }
    }
}
