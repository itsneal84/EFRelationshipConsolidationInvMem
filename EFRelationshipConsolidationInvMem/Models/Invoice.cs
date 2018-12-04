using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFRelationshipConsolidationInvMem.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }

        public Invoice()
        {
            Members = new List<Member>();
            Staffs = new List<Staff>();
            Books = new List<Book>();
        }

        //navigational properties
        //one to many relationship between member & invoice
        //this is the 'many'
        public virtual List<Member> Members { get; set; }

        //one to many relationship between staff & invoice
        //this is the 'many'
        public virtual List<Staff> Staffs { get; set; }

        //many to many relationship between book & invoice
        //this is the 'many'
        public virtual List<Book> Books { get; set; }
    }
}