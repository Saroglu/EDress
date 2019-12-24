using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDress.Web.Interfaces;
using EDress.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EDress.Web.Controllers
{
    public class BasketController : Controller
    {
        IBasketViewModelService _basketViewModelService;
        public BasketController(IBasketViewModelService basketViewModelService)
        {
            _basketViewModelService = basketViewModelService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddToBasket(int productId, int quantity = 1)
        {
            _basketViewModelService.AddToBasket(productId, quantity);

            var vm = new AjaxHeaderBasketViewModel
            {
                HeaderBasketHtml = "Buralar değerlenecek",
                TotalItems = _basketViewModelService.TotalItems()
            };
            return Json(1); // toplam öğe sayısı ve sepet html ini döndür.

        }
    }
}