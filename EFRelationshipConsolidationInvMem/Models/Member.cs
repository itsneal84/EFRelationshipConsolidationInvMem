using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFRelationshipConsolidationInvMem.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberAddress { get; set; }

        //navigational properties
        //one to many relationship between member & memberloan
        //this is the 'one'
        [ForeignKey("MemberLoan")]
        public int MemberLoanId { get; set; }
        public virtual MemberLoan MemberLoan { get; set; }

        //one to many relationship between member & invoice
        //this is the 'one'
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}