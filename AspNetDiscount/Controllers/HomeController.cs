using AspNetDiscount.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetDiscount.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var products = db.Products.ToList();

            foreach (var product in products)
            {
                // İndirim yüzdesi var mı 
                var categoryId = product.CategoryId;
                var discount = db.Discounts.FirstOrDefault(d => d.CategoryId == categoryId &&
                (DateTime.Now >= d.StartDate && DateTime.Now <= d.EndDate));

                // Ürünlerin fiyatlarına indirim yapılıyor
                if (discount != null)
                {
                    product.DiscoundedPrice = product.Price - (product.Price * discount.DiscountPercentage / 100);
                    db.SaveChanges();
                }
                else
                {
                    product.DiscoundedPrice = -1;
                    db.SaveChanges();
                }
                
            }

            return View(products);
        }


    }
}