using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class LogInsContracts
    {
        public long Id { get; set; }
        public int IdTask { get; set; }
        public string DebtNumber { get; set; }
        public string DebtFio { get; set; }
        public DateTime? DebtDate { get; set; }
        public int CessionId { get; set; }
        public byte Auditing { get; set; }
        public byte Avtocredit { get; set; }
        public long? PkbId { get; set; }
        public string ErrMess { get; set; }
        public int Status { get; set; }

        public ServiceTasks IdTaskNavigation { get; set; }
    }
}
