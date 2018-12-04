using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFRelationshipConsolidationInvMem.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string BookAuthor { get; set; }
        public string BookTitle { get; set; }

        public Book()
        {
            Invoices = new List<Invoice>();
            MemberLoans = new List<MemberLoan>();
        }

        //navigational properties
        //many to many relationship between book & invoice
        //this is the 'many'
        public virtual List<Invoice> Invoices { get; set; }

        //many to many relationship between book & memberloan
        //this is the 'many'
        public virtual List<MemberLoan> MemberLoans { get; set; }
    }
}