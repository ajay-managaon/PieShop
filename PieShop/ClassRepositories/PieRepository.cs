using PieShop.InterfaceRepositories;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.ClassRepositories
{
    public class PieRepository : IPieRepository
    {
        private readonly ICatergoryRepository categoryRepository;

        public PieRepository(ICatergoryRepository _categoryRepository)
        {
            categoryRepository = _categoryRepository;
        }
        public IEnumerable<Pie> AllPies() => new List<Pie>
        {
                new Pie { pie_id = 1, pie_name = "Strawberry Pie", price = 15.95M, short_description = "Cheese Cake", long_description = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", category = categoryRepository.AllCategories().ToList()[0], image_url = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", in_stock = true, is_pie_of_the_week = false, imageThumanail_url = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg" },
                new Pie { pie_id = 2, pie_name = "Cheese cake", price = 18.95M, short_description = "Lorem Ipsum", long_description = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", category = categoryRepository.AllCategories().ToList()[1], image_url = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", in_stock = true, is_pie_of_the_week = false, imageThumanail_url = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg" },
                new Pie { pie_id = 3, pie_name = "Rhubarb Pie", price = 15.95M, short_description = "Lorem Ipsum", long_description = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", category = categoryRepository.AllCategories().ToList()[0], image_url = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", in_stock = true, is_pie_of_the_week = true, imageThumanail_url = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg" },
                new Pie { pie_id = 4, pie_name = "Pumpkin Pie", price = 12.95M, short_description = "Lorem Ipsum", long_description = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", category = categoryRepository.AllCategories().ToList()[2], image_url = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", in_stock = true, is_pie_of_the_week = true, imageThumanail_url = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg" }

        };

        public Pie GetPieById(int pieId)
        {
            return AllPies().FirstOrDefault(p => p.pie_id == pieId);
        }

        public IEnumerable<Pie> PiesOfTheWeek()
        {
            throw new NotImplementedException();
        }
    }
}
