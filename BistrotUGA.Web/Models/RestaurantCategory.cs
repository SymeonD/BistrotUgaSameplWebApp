using BistrotUGA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BistrotUGA.Web.Models
{
    public class RestaurantCategory
    {
        public RestaurantCategory Restaurant { get; set; }

        public RestaurantCategory(RestaurantCategory restaurant, string name, List<BistrotDish> dishes)
        {
            Restaurant = restaurant;
            Name = name;
            Dishes = dishes;
        }

        public string Name { get; set; }

        public List<BistrotDish> Dishes { get; set; }
    }
}