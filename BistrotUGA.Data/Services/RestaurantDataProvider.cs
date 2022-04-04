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
                new Restaurant{Name = "L'ardoise", Adress = "2 Rue de Miribel", Id = 0 },
                new Restaurant{Name = "O Wasabi Grenoble", Adress = "7 Rue Thiers", Id = 1 },
                new Restaurant{Name = "O 'DELICES DE TUNIS", Adress = "11 Cours de la Libération", Id = 2 }
            };

            _dishes = new List<BistrotDish>() {

                // Entrées
                new BistrotDish{Id = 1 , Name = "Soupe à l'oignon", MenuType = MenuType.Entree, Price = 6, Restaurant = _restaurants[0], Ingredients = new string[] {"Oignons", "Beurre", "Vin blanc", "Farine", "Comté"} },
                new BistrotDish{Id = 2 , Name = "Gyozas", MenuType = MenuType.Entree, Price = 6, Restaurant = _restaurants[1], Ingredients = new string[] {"Poulet", "Oignon", "Poireau", "Sauce soja", "Gingembre", "Ail"}},
                new BistrotDish{Id = 3 , Name = "Salade Tunisienne", MenuType = MenuType.Entree, Price = 6, Restaurant = _restaurants[2], Ingredients = new string[] {"Pomme de terre", "Olives noires", "Piment", "Concombre", "Citron confit", "Thon"}},

                // Plat
                new BistrotDish{Id = 4 , Name = "Braciole Strachnote", MenuType = MenuType.Plat, Price = 20, Restaurant = _restaurants[0], Ingredients = new string[] {"Bavette de cheval", "Persil", "Pates orecchiettes"}},
                new BistrotDish{Id = 5 , Name = "Riz cantonais", MenuType = MenuType.Plat, Price = 13, Restaurant = _restaurants[1], Ingredients = new string[] {"Riz", "Omelette", "Crevette", "Petit pois", "Carotte", "Sauce soja", "Poulet"}},
                new BistrotDish{Id = 6 , Name = "Ojja Merguez", MenuType = MenuType.Plat, Price = 20, Restaurant = _restaurants[2], Ingredients = new string[] {"Merguez", "Tomate", "Poivron", "Piment", "Oeuf", "Harissa", "Ail"}},

                // Dessert
                new BistrotDish{Id = 7 , Name = "Faisselle", MenuType = MenuType.Dessert, Price = 5, Restaurant = _restaurants[0], Ingredients = new string[] {"Faisselle", "Coulis de fruits rouges"}},
                new BistrotDish{Id = 8 , Name = "Perles de coco", MenuType = MenuType.Dessert, Price = 5, Restaurant = _restaurants[1], Ingredients = new string[] {"Farine de riz gluant", "Crème de haricot mungo", "Noix de coco"}},
                new BistrotDish{Id = 9 , Name = "Mille feuille tunisien", MenuType = MenuType.Dessert, Price = 4, Restaurant = _restaurants[2], Ingredients = new string[] {"Oeuf", "Lait", "Sucre", "Vanille", "Sucre glace"}},
                
                // Boisson
                new BistrotDish{Id = 10 , Name = "Pago Abricot", MenuType = MenuType.Boisson, Price = 3, Restaurant = _restaurants[0], Ingredients = new string[] {"Purée d'abricots"}},
                new BistrotDish{Id = 11 , Name = "Kirin", MenuType = MenuType.Boisson, Price = 5, Restaurant = _restaurants[1], Ingredients = new string[] {"Bière Kirin"}},
                new BistrotDish{Id = 12 , Name = "Perrier", MenuType = MenuType.Boisson, Price = 3, Restaurant = _restaurants[2], Ingredients = new string[] {"Eau petillante Perrier"}},
            };

            for(int i = 0; i < 3; i++)
            {
                _restaurants[i].addDish(_dishes[i]);
                _restaurants[i].addDish(_dishes[i+3]);
                _restaurants[i].addDish(_dishes[i+6]);
                _restaurants[i].addDish(_dishes[i+9]);
            }
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
