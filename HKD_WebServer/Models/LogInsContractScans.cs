using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class LogInsContractScans
    {
        public long Id { get; set; }
        public int IdTask { get; set; }
        public int? IdHkd { get; set; }
        public string AmBox { get; set; }
        public string AmFolder { get; set; }
        public string File { get; set; }
        public int ScType { get; set; }
        public string PathIn { get; set; }
        public string PathOut { get; set; }
        public string Hash { get; set; }
        public int StatusCopy { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMess { get; set; }
        public string Keeper { get; set; }
        public string City { get; set; }
        public string Party { get; set; }
        public string Box { get; set; }
        public string Folder { get; set; }
        public Guid? IdCsOnAddScan { get; set; }
        public byte ExistDocument { get; set; }
        public long? IdClient { get; set; }
        public long? IdPkb { get; set; }
        public int? IdPristav { get; set; }
        public long? LenInFile { get; set; }

        public ContractScanExists ExistDocumentNavigation { get; set; }
        public ServiceTasks IdTaskNavigation { get; set; }
        public ContractRequestTypes ScTypeNavigation { get; set; }
        public LogInsContractScansStatuses StatusCopyNavigation { get; set; }
    }
}
