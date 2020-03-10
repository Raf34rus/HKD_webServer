using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class Templates
    {
        public Templates()
        {
            OutsideRequess = new HashSet<OutsideRequess>();
            PartnerTemplates = new HashSet<PartnerTemplates>();
            RequestOutParam = new HashSet<RequestOutParam>();
        }

        public int Id { get; set; }
        public string TemplateName { get; set; }
        public string Path { get; set; }
        public string Dossier { get; set; }
        public string Court { get; set; }
        public string Pts { get; set; }
        public string Email { get; set; }
        public string Fio { get; set; }
        public string Post { get; set; }
        public string City { get; set; }
        public string DocType { get; set; }
        public int? PartnerId { get; set; }
        public string OriginalIl { get; set; }
        public int StatusId { get; set; }

        public ICollection<OutsideRequess> OutsideRequess { get; set; }
        public ICollection<PartnerTemplates> PartnerTemplates { get; set; }
        public ICollection<RequestOutParam> RequestOutParam { get; set; }
    }
}
