using Ef.Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ef.Core.Application.Contract;
using Microsoft.IdentityModel.Tokens;

namespace Ef.Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductCategoryApplication productCategoryApplication;
        public HomeController(ILogger<HomeController> logger, IProductCategoryApplication productCategoryApplication)
        {
            _logger = logger;
            this.productCategoryApplication = productCategoryApplication;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
       public IActionResult ProductCategory()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
