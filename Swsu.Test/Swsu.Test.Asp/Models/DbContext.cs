using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Swsu.Test.Asp.Models
{
    public class GuitarContext : DbContext
    {
        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}