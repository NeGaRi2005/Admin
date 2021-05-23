using A.Application.actions.ProductCategorys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly IProductCategoryApplication productCategoryApplication;

        public CreateModel(IProductCategoryApplication productCategoryApplication)
        {
            this.productCategoryApplication = productCategoryApplication;
        }

        public void OnGet()
        {
        }

        public RedirectToPageResult OnPost(CreateProductCategory command)
        {
            productCategoryApplication.Create(command);
            return RedirectToPage("./ProductCategorys");
        }
    }
}
