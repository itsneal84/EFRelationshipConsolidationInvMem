using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFRelationshipConsolidationInvMem.Models
{
    public class MemberLoan
    {
        [Key]
        public int MemberLoanId { get; set; }
        public DateTime MemberLoanDate { get; set; }

        public MemberLoan()
        {
            Members = new List<Member>();
            Staffs = new List<Staff>();
        }

        //navigational properties
        //one to many relationship between member & memberloan
        //this is the 'many'
        public virtual List<Member> Members { get; set; }

        //navigational properties
        //one to many relationship between memberloan & staff
        //this is the 'many'
        public List<Staff> Staffs { get; set; }
    }
}