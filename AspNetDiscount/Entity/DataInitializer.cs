﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace AspNetDiscount.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){ Name="Technology" },
                new Category(){  Name="Clothes"}
            };
            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }

            List<Product> products = new List<Product>()
            {
                new Product(){ Name= "Phone", Price =1000, CategoryId = 1 },
                new Product(){ Name= "Computer", Price =1500, CategoryId = 1},
                new Product(){ Name= "Shoes", Price =150, CategoryId = 2},
                
            };
            foreach (var item in products)
            {
                context.Products.Add(item);
            }

            List<Discount> discounts = new List<Discount>()
            {
                new Discount(){  CategoryId = 1, DiscountPercentage=10, Name="BlackFriday",
                    StartDate=DateTime.Now, EndDate=new DateTime(2023,04,20)}

            };
            foreach (var item in discounts)
            {
                context.Discounts.Add(item);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}