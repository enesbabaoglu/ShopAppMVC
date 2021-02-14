using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Concrete.EFCore
{
    public static class SeedDatabase
    {
        public static void Seed(){
            
            var context = new ShopContext();
            
            if(context.Database.GetPendingMigrations().Count()==0){
                
                if(context.Categories.Count()==0){
                    context.Categories.AddRange(Categories);
                }
                 if(context.Products.Count()==0){
                    context.Products.AddRange(Products);
                }
            }
            context.SaveChanges();
            
        }

        private static Category[] Categories={
                new Category (){Name="Elektronik"},
                new Category (){Name="Telefon"},
                new Category (){Name="Bilgisayar"}
        };

         private static Product[] Products={
            new Product{Name = "iPhone 8" , Price= 7000 ,ImageUrl="1.jpg", Description= "çok iyi telefon",IsApproved=true},
            new Product{Name = "iPhone 9" , Price= 9000 ,ImageUrl="2.jpg",  Description= " iyi telefon",IsApproved=false},
            new Product{Name = "iPhone X" , Price= 10000 ,ImageUrl="3.jpg",  Description= " Telefon",IsApproved=true},
            new Product{Name = "iPhone XR" , Price= 11000 ,ImageUrl="4.jpg",  Description= " Güzel telefon"}   
        };
    }
}