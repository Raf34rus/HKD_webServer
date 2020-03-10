using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class PartnerTemplates
    {
        public int Id { get; set; }
        public int? PartnerId { get; set; }
        public string Email { get; set; }
        public int? TemplateId { get; set; }
        public string Location { get; set; }
        public string LocationAddress { get; set; }

        public Partners Partner { get; set; }
        public Templates Template { get; set; }
    }
}
