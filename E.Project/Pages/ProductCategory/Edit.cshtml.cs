using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ef.Core.Application.Contract;
using Ef.Core.Applicationn.ProductCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E.Project.Pages.ProductCategory
{
    public class EditModel : PageModel
    {
        public EditProductCategory command;
        public readonly IProductCategoryApplication ProductCategoryApplication;

        public EditModel(IProductCategoryApplication productCategoryApplication)
        {
            ProductCategoryApplication = productCategoryApplication;
        }

        public void OnGet(int id)
        {
            command = ProductCategoryApplication.GetDetails(id);
        }

        public RedirectToPageResult OnPost(EditProductCategory name)
        {
            ProductCategoryApplication.Edit(name);
            return RedirectToPage("./Index");
        }
    }
}
