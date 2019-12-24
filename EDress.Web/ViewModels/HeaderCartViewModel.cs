using EDress.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDress.Web.ViewModels
{
    public class HeaderCartViewModel
    {
        public int TotalItems { get; set; }
        public IReadOnlyCollection<BasketItem> BasketItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
