using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.InterfaceRepositories
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies();
        IEnumerable<Pie> PiesOfTheWeek();
        Pie GetPieById(int pie_id);
    }
}
