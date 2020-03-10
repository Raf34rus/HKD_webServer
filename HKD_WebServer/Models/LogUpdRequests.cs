using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class LogUpdRequests
    {
        public int Id { get; set; }
        public int IdTask { get; set; }
        public int? IdReq { get; set; }
        public int? ReqStatus { get; set; }
        public string Comment { get; set; }

        public ServiceTasks IdTaskNavigation { get; set; }
    }
}
