using A.Application.actions.ProductCategorys;
using System.Collections.Generic;

namespace A.Domian.ProductCategorys
{
    public interface IProductCategoryRepository
    {
        bool Exist(string name);
        ProductCategory Get(long id);
        void Create(ProductCategory name);
      List<ProductCategoryViewModel> Search(string name);
        void Save();


    }
}
