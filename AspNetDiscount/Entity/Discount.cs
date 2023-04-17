﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetDiscount.Entity
{
    // Discount sınıfı, indirimle ilgili bilgileri içerir
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CategoryId { get; set; }
        public decimal DiscountPercentage { get; set; }

        public Category Categories { get; set; }
    }
}