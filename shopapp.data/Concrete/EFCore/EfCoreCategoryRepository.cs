using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EFCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepositoy<Category, ShopContext>, ICategoryRepository
    {

    }
}