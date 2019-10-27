using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Swsu.Test.Asp.Models
{
    public class GuitarDbInitializer : DropCreateDatabaseAlways<GuitarContext>
    {
        protected override void Seed(GuitarContext db)
        {
            db.Guitars.Add(new Guitar { Producer = "Gibson", Model = "Les Paul", Price = 1000 });
            db.Guitars.Add(new Guitar { Producer = "Fender", Model = "Stratocaster", Price = 500 });
            db.Guitars.Add(new Guitar { Producer = "Ibanez", Model = "Rizen", Price = 700 });
            db.Guitars.Add(new Guitar { Producer = "Ibanez", Model = "Rizen", Price = 700 });
            db.Guitars.Add(new Guitar { Producer = "Ibanez", Model = "Rizen", Price = 700 });
            db.Guitars.Add(new Guitar { Producer = "Ibanez", Model = "Rizen", Price = 700 });
            db.Guitars.Add(new Guitar { Producer = "Ibanez", Model = "Rizen", Price = 700 });
            base.Seed(db);
        }
        
    }
}