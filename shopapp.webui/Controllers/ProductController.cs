
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using shopapp.webui.Data;
using shopapp.webui.Models;
using shopapp.webui.ViewModels;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult List(int? id, string q)
        {

            var products = ProductRepository.Products;
            if (id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }
            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(p => p.Name.ToLower().Contains(q.ToLower())).ToList();
            }

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };
            return View(productViewModel);
        }
        public IActionResult Details(int id)
        {


            return View(ProductRepository.GetProductById(id));
        }
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(new Product());
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepository.AddProduct(product);
                return RedirectToAction("list");
            }
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(product);

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(ProductRepository.GetProductById(id));
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
            ProductRepository.EditProduct(product);
            return RedirectToAction("list"); 
            }
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(product);
        }
        [HttpPost]
          public IActionResult Delete(int ProductId)
        {
            ProductRepository.DeleteProduct(ProductId);
           return RedirectToAction("list");
        }
    }
}