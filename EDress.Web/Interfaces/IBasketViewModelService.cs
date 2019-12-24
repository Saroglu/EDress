using EDress.ApplicationCore.Entities;
using EDress.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDress.Web.Interfaces
{
    public interface IBasketViewModelService
    {
        void AddToBasket(int productId, int quantity);
        IReadOnlyCollection<BasketItem> GetBasketItems();

        int TotalItems();

        HeaderCartViewModel GetHeaderCartViewModel();
    }
}
