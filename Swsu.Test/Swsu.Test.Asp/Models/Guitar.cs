using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Swsu.Test.Asp.Models
{
    public class Guitar
    {
        public Guid Id { get; set; }
        [Display(Name = "Производитель")]
        public string Producer { get; set; }
        [Display(Name ="Модель")]
        public string Model { get; set; }
        [Display(Name ="Цена")]
        public decimal Price { get; set; }
        [UIHint("Boolean")]
        public bool IsInStore { get; set; }
    }

}