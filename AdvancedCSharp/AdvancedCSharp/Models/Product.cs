﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvancedCSharp.Models
{
    public class Product
    {
       
            public int ProductID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public float Price { get; set; }
            public string Category { get; set; }
        
    }
}