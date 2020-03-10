using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class ContractScans
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public string FileName { get; set; }
        public long? Size { get; set; }
        public int? ContractId { get; set; }
        public int? Status1c { get; set; }
        public DateTime? InsertDate { get; set; }
        public string Address { get; set; }
        public string InsertUser { get; set; }
        public bool HasDeffect { get; set; }
        public string DeffectDescription { get; set; }
        public int CsType { get; set; }
        public int StatusCopy { get; set; }
        public int? Converted { get; set; }
        public bool? IsEx { get; set; }
        public string HashFile { get; set; }
        public DateTime DateLastUpdate { get; set; }
        public string Keeper { get; set; }
        public string City { get; set; }
        public string Party { get; set; }
        public string Box { get; set; }
        public string Folder { get; set; }
        public byte ExistDocument { get; set; }
        public DateTime? InsertDateScan { get; set; }

        public Contracts Contract { get; set; }
        public ContractRequestTypes CsTypeNavigation { get; set; }
        public ContractScanExists ExistDocumentNavigation { get; set; }
        public StatusesCopy StatusCopyNavigation { get; set; }
    }
}
