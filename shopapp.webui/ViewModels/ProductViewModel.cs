using System.Collections.Generic;
using shopapp.webui.Models;

namespace shopapp.webui.ViewModels
{
    public class ProductViewModel
    {
        public Category Category { get; set; }
        public List<Product> Products { get; set; }
    }
}