using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Swsu.Test.Asp.Models
{
    public class Purchase
    {
        public Guid PurchaseId { get; set; }

        public string Person { get; set; }

        public string Address { get; set; }
    
        public Guid GuitarId { get; set; }

        public DateTime Date { get; set; }
    }
}