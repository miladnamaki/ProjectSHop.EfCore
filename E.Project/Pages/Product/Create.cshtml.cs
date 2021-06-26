using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Ef.Core.Application.Contract;
using Ef.Core.Applicationn.Product;
using Ef.Core.Applicationn.ProductCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E.Project.Pages.Product
{
    public class CreateModel : PageModel
    {
        public SelectList productcategory;
        private readonly IProductApplication productapplication;
        private readonly IProductCategoryApplication productCategoryApplication;
        public CreateModel(IProductApplication productapplication, IProductCategoryApplication productCategoryApplication)
        {
            this.productapplication = productapplication;
            this.productCategoryApplication = productCategoryApplication;
        }


        public void OnGet()
        {
            productcategory = new SelectList(productCategoryApplication.Gettall(), "Id", "Name");
            
        }

        public RedirectToPageResult OnPost(CreateProduct command)
        {
            productapplication.Create(command);
            return RedirectToPage("./Index");
        }
    }
}
