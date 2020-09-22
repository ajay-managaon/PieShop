using PieShop.InterfaceRepositories;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.ClassRepositories
{
    public class CategoryRepository : ICatergoryRepository
    {
        public IEnumerable<Category> AllCategories() =>
        new List<Category>
        {
            new Category{category_id =1,category_name="Fruit Pies",description="All Fruit Pies"},
            new Category{category_id =1,category_name="Cake Pies",description="All cake Pies"},
            new Category{category_id =1,category_name="lol Pies",description="All lol Pies"},
            new Category{category_id =1,category_name="lolwa Pies",description="All lolwa Pies"},
        };
    }
}
