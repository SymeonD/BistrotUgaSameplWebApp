using BistrotUGA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistrotUGA.Data.Services
{
    public class RestaurantDataProvider : IDishData
    {
        private List<BistrotDish> _dishes;
        private List<Restaurant> _restaurants;

        public RestaurantDataProvider()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant{Name = "La Girole", Adress = "2 Rue de le plaine", Id = 1 },
                new Restaurant{Name = "La Girole2", Adress = "2 Rue de le plaine", Id = 2 }
            };

            _dishes = new List<BistrotDish>() {

                // Plat
                new BistrotDish{Id = 1 , Name = "Boeuf Bourgignonne", MenuType = MenuType.Plat, Price = 15, Restaurant = _restaurants[0]},
                new BistrotDish{Id = 2 , Name = "Fondue savoyarde", MenuType = MenuType.Plat, Price = 20},
                
                // Boisson
                new BistrotDish{Id = 3 , Name = "Eau", MenuType = MenuType.Boisson, Price = 2, Restaurant = _restaurants[0]},
                new BistrotDish{Id = 4 , Name = "Coca", MenuType = MenuType.Boisson, Price = 3},

                // Dessert
                new BistrotDish{Id = 5 , Name = "Crème Brulée", MenuType = MenuType.Dessert, Price = 5},
                new BistrotDish{Id = 6 , Name = "Tarte tatin", MenuType = MenuType.Dessert, Price = 5},

                // Fruits de Mer
                new BistrotDish{Id = 7 , Name = "Huitres", MenuType = MenuType.FruitdeMer, Price = 20},
                new BistrotDish{Id = 8 , Name = "Moules", MenuType = MenuType.FruitdeMer, Price = 15},

                // Glaces
                new BistrotDish{Id = 9 , Name = "Glace à la vanille", MenuType = MenuType.Glace, Price = 5},
                new BistrotDish{Id = 10 , Name = "Glace au chocolat", MenuType = MenuType.Glace, Price = 5},

                
                // Entrees
                new BistrotDish{Id = 11 , Name = "Saumon Tartare", MenuType = MenuType.Plat, Price = 8},
                new BistrotDish{Id = 22 , Name = "Saucisson", MenuType = MenuType.Plat, Price = 6},
            };

            _dishes[0].setRestaurant(_restaurants[0]);
        }

        public void AddDish(BistrotDish dish)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BistrotDish> GetAllDishes()
        {
            return _dishes.OrderBy(d => d.Name);
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return _restaurants;
        }

        public List<BistrotDish> GetDishesByCategory(MenuType Type)
        {
            return _dishes.Where(d => d.MenuType == Type).ToList();
        }

        public List<BistrotDish> GetDishesByRestaurant(Restaurant restaurant)
        {
            return _dishes.Where(d => d.Restaurant == restaurant).ToList();
        }
    }
}
