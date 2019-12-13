using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EDress.Web.Models;
using EDress.ApplicationCore.Interfaces;

namespace EDress.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices] ICategoryService categoryService)
        {
            return View(categoryService.ListCategories());
        }

        public IActionResult Privacy()
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
