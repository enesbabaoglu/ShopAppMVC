using System.Collections.Generic;
using System.Linq;
using shopapp.webui.Models;

namespace shopapp.webui.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products =null; 

        static ProductRepository()
        {
            _products=new List<Product>
            {
                new Product{ProductId=1,Name = "iPhone 8" , Price= 7000 , Description= "çok iyi telefon",IsApproved=true,ImageUrl="1.jpg",CategoryId=1},
                new Product{ProductId=2,Name = "iPhone 9" , Price= 9000 , Description= " iyi telefon",IsApproved=false,ImageUrl="2.jpg",CategoryId=1},
                new Product{ProductId=3,Name = "iPhone X" , Price= 10000 , Description= " Telefon",IsApproved=true,ImageUrl="3.jpg",CategoryId=1},
                new Product{ProductId=4,Name = "iPhone XR" , Price= 11000 , Description= " Güzel telefon",ImageUrl="4.jpg",CategoryId=1},
                new Product{ProductId=5,Name = "Lenovo 8" , Price= 7000 , Description= "çok iyi Bilgisayar",IsApproved=true,ImageUrl="1.jpg",CategoryId=2},
                new Product{ProductId=6,Name = "Lenovo 9" , Price= 9000 , Description= " iyi Bilgisayar",IsApproved=false,ImageUrl="2.jpg",CategoryId=2},
                new Product{ProductId=7,Name = "Lenovo X" , Price= 10000 , Description= " Bilgisayar",IsApproved=true,ImageUrl="3.jpg",CategoryId=2},
                new Product{ProductId=8,Name = "Lenovo XR" , Price= 11000 , Description= " Güzel Bilgisayar",ImageUrl="4.jpg",CategoryId=2},

            
            
            };
        }
        public static List<Product> Products{
            get
            {
                return _products;
            }
        }
        public static void AddProduct(Product product){
            _products.Add(product);
        }
        public static Product GetProductById(int id){
            return _products.FirstOrDefault(p=>p.ProductId==id);
        }
    
    }
    
}