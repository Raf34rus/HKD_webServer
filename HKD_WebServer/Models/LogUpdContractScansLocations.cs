using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class LogUpdContractScansLocations
    {
        public long Id { get; set; }
        public int IdTask { get; set; }
        public int? IdHkd { get; set; }
        public int CsType { get; set; }
        public string Keeper { get; set; }
        public string Сity { get; set; }
        public string Party { get; set; }
        public string Box { get; set; }
        public string Folder { get; set; }
        public string Comment { get; set; }
        public string FileName { get; set; }
        public int StatusUpd { get; set; }
        public string ErrMess { get; set; }
        public byte ExistDocument { get; set; }
        public long? IdClient { get; set; }
        public long? IdPkb { get; set; }
        public int? IdPristav { get; set; }

        public ContractRequestTypes CsTypeNavigation { get; set; }
        public ContractScanExists ExistDocumentNavigation { get; set; }
        public Contracts IdHkdNavigation { get; set; }
        public ServiceTasks IdTaskNavigation { get; set; }
    }
}
