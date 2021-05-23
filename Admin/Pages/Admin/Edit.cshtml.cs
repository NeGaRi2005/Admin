using A.Application.actions.ProductCategorys;
using A.Application.ProductCategorys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.Pages.Admin
{
    public class EditModel : PageModel
    {
       [BindProperty]public RenameProductCaregory RenameProductCaregory { get; set; }
        private readonly IProductCategoryApplication _productCategory;

        public EditModel(IProductCategoryApplication productCategory)
        {
            _productCategory = productCategory;
        }

        public void OnGet(long id)
        {
            RenameProductCaregory = _productCategory.Get(id);
        }

        public RedirectToPageResult OnPost()
        {
            _productCategory.Rename(RenameProductCaregory);
            return RedirectToPage("./ProductCategorys");
        }
    }
}
