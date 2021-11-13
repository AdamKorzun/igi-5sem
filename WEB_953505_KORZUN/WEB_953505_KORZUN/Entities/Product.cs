﻿using System;
namespace WEB_953505_KORZUN.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; } 
        public double Price { get; set; } 
        public string Image { get; set; }

        
        public int ProductGroupId { get; set; }
        public ProductGroup Group { get; set; }

        public Product()
        {
        }
    }
}
