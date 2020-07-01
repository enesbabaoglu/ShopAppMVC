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
                new Product{Name = "iPhone X" , Price= 9000 , Description= " iyi telefon",IsApproved=false},
                new Product{Name = "iPhone X" , Price= 9000 , Description= " iyi telefon",IsApproved=true},
                new Product{Name = "iPhone X" , Price= 9000 , Description= " iyi telefon"},
                new Product{Name = "iPhone X" , Price= 9000 , Description= " iyi telefon",IsApproved=true}
            };
            var category = new Category{Name="Telefonlar", Description="Telefon Kategorisi"};
            
            var productViewModel= new ProductViewModel{Category=category,Products=products};
            
            
            return View(productViewModel);
        }
        public IActionResult Details(){
          
           
            return View();
        }
    }
}