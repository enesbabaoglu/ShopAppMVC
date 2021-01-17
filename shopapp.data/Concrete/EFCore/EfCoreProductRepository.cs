using System.Collections.Generic;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EFCore
{
    public class EfCoreProductRepository : EfCoreGenericRepositoy<Product, ShopContext>, IProductRepository
    {
        public List<Product> GetPopularProduct()
        {
            throw new System.NotImplementedException();
        }

    }
}