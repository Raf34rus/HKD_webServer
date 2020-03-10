using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class Log
    {
        public long Id { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; }
        public string Text { get; set; }
        public string Username { get; set; }
        public string Process { get; set; }
        public string Group { get; set; }
        public long? OperationIdentify { get; set; }
        public string Ip { get; set; }
        public string Error { get; set; }
        public string Reestr { get; set; }
    }
}
