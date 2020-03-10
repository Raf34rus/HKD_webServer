using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class Partners
    {
        public Partners()
        {
            Cessions = new HashSet<Cessions>();
            PartnerTemplates = new HashSet<PartnerTemplates>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool PrimaryCreditor { get; set; }

        public ICollection<Cessions> Cessions { get; set; }
        public ICollection<PartnerTemplates> PartnerTemplates { get; set; }
    }
}
