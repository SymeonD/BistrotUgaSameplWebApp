using BistrotUGA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistrotUGA.Data.Services
{
    public interface IDishData
    {
        IEnumerable<BistrotDish> GetAllDishes();
        IEnumerable<Restaurant> GetAllRestaurants();
        void AddDish(BistrotDish dish);
        List<BistrotDish> GetDishesByCategory(MenuType Type);
        List<BistrotDish> GetDishesByRestaurant(Restaurant restaurant);
    }

    
}
