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

        public RedirectToPageResult OnPost(CreateProuductCategory command)
        {
            productCategoryApplication.Create(command);
            return RedirectToPage("./Index");
        }
    }
}
