using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class FastRequess
    {
        public int Id { get; set; }
        public int ContractRequessId { get; set; }
        public int RequessResonId { get; set; }
        public string Descr { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public string Address { get; set; }
        public string CollectorFio { get; set; }
        public string BossEmail { get; set; }

        public ContractRequess ContractRequess { get; set; }
        public RequessReson RequessReson { get; set; }
    }
}
