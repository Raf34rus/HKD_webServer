using System;
using System.Collections.Generic;

namespace HKD_WebServer.Models
{
    public partial class ContractSigns
    {
        public ContractSigns()
        {
            ContractsAuditingNavigation = new HashSet<Contracts>();
            ContractsAvtocreditNavigation = new HashSet<Contracts>();
            ContractsIsAssigmentNavigation = new HashSet<Contracts>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public ICollection<Contracts> ContractsAuditingNavigation { get; set; }
        public ICollection<Contracts> ContractsAvtocreditNavigation { get; set; }
        public ICollection<Contracts> ContractsIsAssigmentNavigation { get; set; }
    }
}
