﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Swsu.Test.Asp.Models
{
    public class Guitar
    {
        public Guid Id { get; set; }

        public string Producer { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public bool IsInStore { get; set; }
    }

}