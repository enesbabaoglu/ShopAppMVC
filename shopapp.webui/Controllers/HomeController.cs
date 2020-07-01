using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{
    //localhost:5000/home
    public class HomeController: Controller
    {
        public IActionResult Index(){
            return View();
        }
         public IActionResult About(){
            return View();
        }

         public IActionResult Contact(){
            return View("MyView");
        }
        
        
    }
}