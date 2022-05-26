﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrnekSite2.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}