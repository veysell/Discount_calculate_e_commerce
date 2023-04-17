using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetDiscount.Entity
{
    // Kategori sınıfı, ürün kategorilerini içerir
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public List<Discount> Discounts { get; set; }
    }
}