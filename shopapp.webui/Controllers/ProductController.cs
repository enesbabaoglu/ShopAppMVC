using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        public string Index(){
            return "product/index";
        }
        public string list(){
            return "product/list";
        }
         public string Details(){
            return "product/details";
        }
    }
}