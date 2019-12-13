using EDress.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDress.ApplicationCore.Interfaces
{
    public interface ICategoryService
    {
        List<Category> ListCategories();
    }
}
