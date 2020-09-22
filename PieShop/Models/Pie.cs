using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class Pie
    {
        [Key]
        public int pie_id { get; set; }
        public string pie_name { get; set; }
        public string short_description { get; set; }
        public string long_description { get; set; }
        public string allergy_information { get; set; }
        public decimal price { get; set; }
        public string image_url { get; set; }
        public string imageThumanail_url { get; set; }
        public bool is_pie_of_the_week { get; set; }
        public bool in_stock { get; set; }
        public int category_id { get; set; }
        public Category category { get; set; }
    }
}
