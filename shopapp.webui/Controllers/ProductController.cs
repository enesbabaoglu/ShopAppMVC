using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;
using shopapp.webui.ViewModels;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(){
             var product = new Product{Name= "Samsung", Price=3000 , Description = "Güzel Telefon"};
           string category = "telefonlar";
           
           ViewData["Category"] = category; 
           ViewData["Product"]=product ; 
            return View();
        }
        public IActionResult List(){
            var products = new List<Product>(){
                new Product{Name = "iPhone 8" , Price= 7000 , Description= "çok iyi telefon",IsApproved=true},
                new Product{Name = "iPhone 9" , Price= 9000 , Description= " iyi telefon",IsApproved=false},
                new Product{Name = "iPhone X" , Price= 10000 , Description= " Telefon",IsApproved=true},
                new Product{Name = "iPhone XR" , Price= 11000 , Description= " Güzel telefon"},
            };

            var categories =new List<Category>(){
                new Category {Name="Telefonlar", Description="Telefon Kategorisi"},
                new Category {Name="Bilgisayarlar", Description="Bilgisayar Kategorisi"},
                new Category {Name="Elektronik", Description="Elektronik Kategorisi"}

            };
            
            
            var productViewModel= new ProductViewModel{
                Categories=categories,
                Products=products
            };         
            return View(productViewModel);
        }
        public IActionResult Details(){
          
           
            return View();
        }
    }
}