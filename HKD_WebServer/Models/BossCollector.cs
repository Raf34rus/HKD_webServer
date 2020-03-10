using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class BossCollector
    {
        public int Id { get; set; }
        public string BossName { get; set; }
        public string Email { get; set; }
        public string Pristav { get; set; }
    }
}
