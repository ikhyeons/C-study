using Dul.Data;
using System.Collections.Generic;
using System.Linq;

namespace InMemoryDatabase
{
    public class CategoryRepositoryInMemory : ICategoryRepository
    {
        private static List<Category> _categories = new List<Category>();

        public CategoryRepositoryInMemory()
        {
            _categories = new List<Category>()
            {
                new Category() { CategoryId = 1, CategoryName = "책" },
                new Category() { CategoryId = 2, CategoryName = "강의" },
                new Category() { CategoryId = 3, CategoryName = "컴퓨터" }
            };
        }

        public Category Add(Category model)
        {
            model.CategoryId = _categories.Max(c => c.CategoryId) + 1;
            _categories.Add(model);
            return model;
        }
        public Category Browse(int id)
        {
            return _categories.Where(c=> c.CategoryId == id). SingleOrDefault();
        }

        public bool Delete(int id)
        {
            int r = _categories.RemoveAll(c => c.CategoryId == id);
            if (r > 0)
            {
                return true;
            }
            return false;
        }

        public bool Edit(Category model)
        {
            var result = _categories
                .Where(c => c.CategoryId == model.CategoryId)
                .Select(c=> { c.CategoryName = model.CategoryName; return c; })
                .SingleOrDefault();

            if(result != null)
            {
                return true;
            }
            return false;
        }

        public int Has()
        {
            return _categories.Count;
        }

        public IEnumerable<Category> Ordering(OrderOption orderOption)
        {
            IEnumerable<Category> categories;
            switch (orderOption)
            {
                case OrderOption.Ascending:
                    categories = _categories.OrderBy(c => c.CategoryName);
                    break;
                case OrderOption.Descending:
                    categories = (from category in _categories
                                  orderby category.CategoryName descending
                                  select category);
                    break;
                default:
                    categories = _categories;
                    break;
            }
            return categories;
        }

        public List<Category> Paging(int pageNumber = 1, int pageSize = 10)
        {
            return
                _categories
                    .Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<Category> Read()
        {
            return _categories;
        }

        public List<Category> Search(string query)
        {
            return _categories
                .Where(category=> category.CategoryName.Contains(query)).ToList();
        }
    }
}