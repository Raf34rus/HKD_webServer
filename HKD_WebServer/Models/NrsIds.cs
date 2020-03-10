using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class NrsIds
    {
        public int IdNrs { get; set; }
        public int? IdPristav { get; set; }
        public string Contract { get; set; }
        public DateTime? CreditDate { get; set; }
        public string Fio { get; set; }
        public string IdPkb { get; set; }
        public string Partner { get; set; }
        public string Cession { get; set; }
        public long? IdClient { get; set; }
    }
}
