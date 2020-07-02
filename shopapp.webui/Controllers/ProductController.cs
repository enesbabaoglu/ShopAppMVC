
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Data;
using shopapp.webui.Models;
using shopapp.webui.ViewModels;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(){
           
            return View();
        }
        public IActionResult List(int? id){
            
            var products = ProductRepository.Products;
            if(id!=null){
                products= products.Where(p=>p.CategoryId==id).ToList();
            }
            
            var productViewModel= new ProductViewModel(){
                Products= products
            };         
            return View(productViewModel);
        }
        public IActionResult Details(int id){
          
           
            return View(ProductRepository.GetProductById(id));
        }
    }
}