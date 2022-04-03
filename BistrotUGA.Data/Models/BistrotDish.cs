using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistrotUGA.Data.Models
{
    public class BistrotDish
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public MenuType MenuType { get; set; }

        public Restaurant Restaurant;

        public Restaurant GetRestaurant()
        {
            return this.Restaurant;
        }

        public void setRestaurant(Restaurant restaurant)
        {
            this.Restaurant = restaurant;
            Console.Write(restaurant.Name);
            restaurant.addDish(this);
        }

        public float Price { get; set; }

        public byte[] Image { get; set; }   

    }
}
