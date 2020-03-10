using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class RequestOutParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TemplateId { get; set; }
        public int Type { get; set; }

        public Templates Template { get; set; }
    }
}
