using A.Application.actions.ProductCategorys;
using A.Domian.ProductCategorys;
using A.Domian.Services;
using System.Collections.Generic;

namespace A.Application.ProductCategorys
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IProductCategoryValidatorService productCategoryValidatorService;
        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public ProductCategoryApplication(IProductCategoryValidatorService productCategoryValidatorService)
        {
            this.productCategoryValidatorService = productCategoryValidatorService;
        }

        public void Create(CreateProductCategory create)
        {

            var newproductCategory = new ProductCategory(create.Title,productCategoryValidatorService);
            _productCategoryRepository.Create(newproductCategory);
            _productCategoryRepository.Save();

        }

        public List<ProductCategoryViewModel> List(string name)
        {
          return  _productCategoryRepository.Search(name);
        }

        public void Rename(RenameProductCaregory command)
        {
            var name = _productCategoryRepository.Get(command.Id);
            name.Rename(command.Title);
            _productCategoryRepository.Save();
        }

        public RenameProductCaregory Get(long id)
        {
         var rename = _productCategoryRepository.Get(id);
         return new RenameProductCaregory
        { 
                Id=rename.Id,
                Title=rename.Name
              
        };
           

        }

        public void Activate(long id)
        {
            var activate = _productCategoryRepository.Get(id);
            activate.Activate();
            _productCategoryRepository.Save();
        }

        public void Remove(long id)
        {
            var remove = _productCategoryRepository.Get(id);
            remove.Remove();
            _productCategoryRepository.Save();
        }
    }
}
