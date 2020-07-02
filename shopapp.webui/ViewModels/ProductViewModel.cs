using System.Collections.Generic;
using shopapp.webui.Models;

namespace shopapp.webui.ViewModels
{
    public class ProductViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}