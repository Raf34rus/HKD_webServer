using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class LogConverter
    {
        public int Id { get; set; }
        public DateTime? DateConvert { get; set; }
        public string Host { get; set; }
        public int? Result { get; set; }
        public string OldPath { get; set; }
        public string ErrorMessage { get; set; }
        public string NewPath { get; set; }
        public string FileExtension { get; set; }
        public Guid? IdContractScan { get; set; }
    }
}
