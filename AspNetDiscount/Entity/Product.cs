using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetDiscount.Entity
{
    // Ürün sınıfı, ürün bilgilerini içerir
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        
        public Category Categories { get; set; }
    }
}