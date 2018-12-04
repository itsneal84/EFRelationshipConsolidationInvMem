using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFRelationshipConsolidationInvMem.Models
{
    public class EfRelationshipConsInvMemDBContext : DbContext
    {
        public List<Member> Members { get; set; }
        public List<MemberLoan> MemberLoans { get; set; }
        public List<Staff> Staffs { get; set; }
        public List<Invoice> Invoices { get; set; }
        public List<Book> Books { get; set; }

        public EfRelationshipConsInvMemDBContext() : base("EFRelationshipsConnectionInvMem")
        {
            Database.SetInitializer<EfRelationshipConsInvMemDBContext>(new DropCreateDatabaseIfModelChanges<EfRelationshipConsInvMemDBContext>());
        }
    }
}