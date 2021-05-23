using A.Application.actions.ProductCategorys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Admin.Pages.Admin
{
    public class ProductCategorysModel : PageModel
    {
        public List<ProductCategoryViewModel> productCategories { get; set; }
        private readonly IProductCategoryApplication _productCategoryApplication;

        public ProductCategorysModel(IProductCategoryApplication productCategoryApplication)
        {
            _productCategoryApplication = productCategoryApplication;
        }

        public void OnGet(string name)
        {
            productCategories = _productCategoryApplication.List(name);
        }

        public RedirectToPageResult OnPostRemove(long id)
        {
            _productCategoryApplication.Remove(id);
            return RedirectToPage("./ProductCategorys");

        }

        public RedirectToPageResult OnPostActivate(long id)
        {
            _productCategoryApplication.Activate(id);
            return RedirectToPage("./ProductCategorys");
        }
    }
}
