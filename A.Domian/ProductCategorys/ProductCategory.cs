using A.Domian.Exceptions;
using A.Domian.Products;
using A.Domian.Services;
using System;
using System.Collections.Generic;

namespace A.Domian.ProductCategorys
{
    public class ProductCategory
    {
        public ProductCategory(string name, IProductCategoryValidatorService validatorService)
        {
            Name = name;
            IsStock = false;
            Time = DateTime.Now;
            IsNullOrEmpty(name);
            validatorService.CheckThatThisRecordAlreadyExists(name);
        }

        public long Id { get;private set; }
        public string Name { get; private set; }
        public bool IsStock { get; private set; }
        public DateTime Time { get; private set; }
        public List<Product>Products { get; private set; }


        public void IsNullOrEmpty(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                throw new DuplicatedRecordException("همچین محصولی با این نام وجود دارد");
        }

        public void Rename(string name)
        {
        IsNullOrEmpty(name);
            Name = name;
        }

        public void Remove()
        {
            IsStock = true;
        }
        public void Activate()
        {
            IsStock = false;
        }
    }
}
