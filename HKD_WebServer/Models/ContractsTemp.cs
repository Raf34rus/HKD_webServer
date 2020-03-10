using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class ContractsTemp
    {
        public int Id { get; set; }
        public Guid? IdSess { get; set; }
        public int? IdHkd { get; set; }
    }
}
