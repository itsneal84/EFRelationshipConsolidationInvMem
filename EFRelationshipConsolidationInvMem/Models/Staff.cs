using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFRelationshipConsolidationInvMem.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        public string StaffName { get; set; }

        //navigational properties
        //one to many relationship between memberloan & staff
        //this is the 'one'
        [ForeignKey("MemberLoan")]
        public int MemberLoadId { get; set; }
        public virtual MemberLoan MemberLoan { get; set; }

        //one to many relationship between staff & invoice
        //this is the 'one'
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}