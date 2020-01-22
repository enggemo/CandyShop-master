using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category{CategoryId=1, CategoryName="Hard candy", CategoryDescription="Awesome candy"},
            new Category{CategoryId=2, CategoryName="Chocolate Dark", CategoryDescription="Greate dark choco"},
            new Category{CategoryId=3, CategoryName="Fruit candy", CategoryDescription="sweet fruits"}
        };
    }
}
