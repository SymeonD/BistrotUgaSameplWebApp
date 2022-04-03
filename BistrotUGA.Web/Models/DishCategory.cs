using BistrotUGA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BistrotUGA.Web.Models
{
    public class DishCategory
    {
        public MenuType Type { get; set; }

        public DishCategory(MenuType type, string name, List<BistrotDish> dishes)
        {
            Type = type;
            Name = name;
            Dishes = dishes;
        }

        public String Name { get; set; }

        public List<BistrotDish> Dishes { get; set; }
    }
}