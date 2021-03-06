﻿using EDress.ApplicationCore.Entities;
using EDress.ApplicationCore.Interfaces;
using EDress.Web.Interfaces;
using EDress.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDress.Web.Services
{

    public class BasketViewModelService : IBasketViewModelService
    {
        IBasketService _basketService;
        IRepository<Product> _productRepository;
        public BasketViewModelService(IBasketService basketService, IRepository<Product> productRepository)
        {
            _basketService = basketService;
            _productRepository = productRepository;
        }
        public void AddToBasket(int productId, int quantity)
        {
            var product = _productRepository.GetById(productId);
            _basketService.AddItemToBasket(product.Id, product.ProductName, product.UnitPrice, product.ImagePath, quantity);
        }

        public HeaderCartViewModel GetHeaderCartViewModel()
        {
            var vm = new HeaderCartViewModel
            {
                TotalItems = _basketService.GetBasketItemCount(),
                BasketItems = _basketService.BasketItems,
                TotalPrice = _basketService.BasketItems.Sum(x => x.Quantity * x.UnitPrice)
            };
            return vm;
        }

        public void RemoveItemFromBasket(int productId)
        {
            _basketService.RemoveItemFromBasket(productId);
        }

        public int TotalItems()
        {
            return _basketService.GetBasketItemCount();
        }

        IReadOnlyCollection<BasketItem> IBasketViewModelService.GetBasketItems()
        {
            return _basketService.BasketItems;
        }
    }
}
