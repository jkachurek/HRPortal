using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRPortal.Web.Models.Data;

namespace HRPortal.Web.Models.Repositories
{
    public class CategoryRepository
    {
        private static List<Category> _categories;

        static CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category {CategoryId = 1, Name = "Cat1"},
                new Category {CategoryId = 2, Name = "Cat2"},
                new Category {CategoryId = 3, Name = "Cat3"}
            };
        }

        public static IEnumerable<Category> GetAll()
        {
            return _categories;
        }

        public static Category Get(int id)
        {
            return _categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public static int GetNextCategoryId()
        {
            if (_categories.Count == 0) return 1;
            return _categories.Max(c => c.CategoryId) + 1;
        }

        public static Category Add(string name)
        {
            var newCategory = new Category
            {
                CategoryId = GetNextCategoryId(),
                Name = name
            };
            _categories.Add(newCategory);
            return newCategory;
        }
    }
}