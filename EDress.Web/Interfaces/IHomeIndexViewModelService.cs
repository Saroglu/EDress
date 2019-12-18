using EDress.ApplicationCore.Entities;
using EDress.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDress.Web.Interfaces
{
    public interface IHomeIndexViewModelService
    {
        HomeIndexViewModel GetHomeIndexViewModel(int? categoryId, int pageIndex, int productsPerPage);

    }
}
