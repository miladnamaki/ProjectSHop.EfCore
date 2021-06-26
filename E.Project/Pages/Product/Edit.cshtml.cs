using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ef.Core.Application.Contract;
using Ef.Core.Applicationn.Product;
using Ef.Core.Applicationn.ProductCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E.Project.Pages.Product
{
    public class EditModel : PageModel
    {
        public EditProduct command;
        public SelectList ProductCategory; 
        private readonly IProductApplication ProductApplication;
        private readonly IProductCategoryApplication productCategoryApplication;

        public EditModel(IProductCategoryApplication productCategoryApplication, IProductApplication productApplication)
        {
            this.productCategoryApplication = productCategoryApplication;
            ProductApplication = productApplication;
        }


        public void OnGet(int id)
        {
            ProductCategory = new SelectList(productCategoryApplication.Gettall(), "Id", "Name");
            command = ProductApplication.GetDetails(id);
        }

        public RedirectToPageResult OnPost(EditProduct commandd)
        {
            ProductApplication.Edit(commandd);
            return RedirectToPage("./Index");
        }
    }
}
