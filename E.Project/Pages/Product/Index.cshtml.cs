using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ef.Core.Application.Contract;
using Ef.Core.Applicationn.Product;
using Ef.Core.Applicationn.ProductCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E.Project.Pages.Product
{
   
    public class IndexModel : PageModel
    {
        public List<ProductViewModel> Products;    
        private readonly IProductApplication productApplication;

        public IndexModel(IProductApplication productApplication)
        {
            this.productApplication = productApplication;
        }

        public void OnGet(ProductSearchModel command)
        {
            Products = productApplication.Search(command);
        }
    }
}
