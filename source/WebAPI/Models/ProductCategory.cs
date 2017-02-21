﻿using System.Collections.Generic;

namespace SimpleODataApiWithEf.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}