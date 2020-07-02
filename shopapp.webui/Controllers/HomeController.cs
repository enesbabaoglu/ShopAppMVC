using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Data;
using shopapp.webui.Models;
using shopapp.webui.ViewModels;

namespace shopapp.webui.Controllers
{
    //localhost:5000/home
    public class HomeController: Controller
    {
        public IActionResult Index(){
            var productViewModel= new ProductViewModel{
                Products=ProductRepository.Products
            };         
            return View(productViewModel);
        }
         public IActionResult About(){
            return View();
        }

         public IActionResult Contact(){
            return View("MyView");
        }
        
        
    }
}