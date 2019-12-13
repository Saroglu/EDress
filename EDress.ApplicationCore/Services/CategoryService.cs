using EDress.ApplicationCore.Entities;
using EDress.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDress.ApplicationCore.Services
{
    public class CategoryService : ICategoryService
    {
        IRepository<Category> _categoryRepository;
        public CategoryService(IRepository<Category> categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }

        public List<Category> ListCategories()
        {
            return _categoryRepository.GetAll().ToList();
        }
    }
}
