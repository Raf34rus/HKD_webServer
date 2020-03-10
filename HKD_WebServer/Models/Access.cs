using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class Access
    {
        public string Username { get; set; }
        public DateTime Lastaccess { get; set; }
        public long Id { get; set; }
        public string Uid { get; set; }
    }
}
