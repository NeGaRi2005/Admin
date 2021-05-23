using A.Application.actions.ProductCategorys;
using A.Domian.ProductCategorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace A.Infrastructure.Repositorys
{
    public class ProductCategoryRepositorry : IProductCategoryRepository
    {
        private readonly EFContext _eFContext;

        public ProductCategoryRepositorry(EFContext eFContext)
        {
            _eFContext = eFContext;
        }

        public void Create(ProductCategory Name)
        {
            _eFContext.ProductCategories.Add(Name);
            Save();
        }

        public bool Exist(string name)
        {
            return _eFContext.ProductCategories.Any(x => x.Name == name);
        }

        public ProductCategory Get(long id)
        {
            return _eFContext.ProductCategories.FirstOrDefault(x => x.Id == id);

        }

        public void Save()
        {
            _eFContext.SaveChanges();
        }

        public List<ProductCategoryViewModel> Search(string name)
        {

            var query = _eFContext.ProductCategories.Select(x => new ProductCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                IsStock = x.IsStock,
                Time = x.Time.ToString()

            });
            if (!string.IsNullOrWhiteSpace(name)) 
            query = query.Where(x => x.Name.Contains(name));
            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
