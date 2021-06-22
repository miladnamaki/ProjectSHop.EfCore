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
   
    public class IndexModel : PageModel
    {
        public List<ProductCategoryViewModel> Product;    
        private readonly IProductCategoryApplication productCategoryApplication;

        public IndexModel(IProductCategoryApplication productCategoryApplication)
        {
            this.productCategoryApplication = productCategoryApplication;
        }

        public void OnGet(string name)
        {
            Product = productCategoryApplication.Search(name);
        }
    }
}
