using System.Collections.Generic;

namespace A.Application.actions.ProductCategorys
{
    public interface IProductCategoryApplication
    {
        void Create(CreateProductCategory command);
        List<ProductCategoryViewModel> List(string name);
        void Rename(RenameProductCaregory command);
        RenameProductCaregory Get(long id);
        void Activate(long id);
        void  Remove(long id);
    }
}
