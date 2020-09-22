using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.InterfaceRepositories
{
    public interface ICatergoryRepository
    {
        IEnumerable<Category> AllCategories();
    }
}
