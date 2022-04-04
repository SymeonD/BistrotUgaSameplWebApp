using BistrotUGA.Data.Models;
using BistrotUGA.Data.Services;
using BistrotUGA.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BistrotUGA.Web.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IDishData _dataProvider;

        public RestaurantController(IDishData dataProvider)
        {
            _dataProvider = dataProvider;
        }

        // GET: Restaurant
        public ActionResult Dishes(int id)
        {
            var restaurant = _dataProvider.GetAllRestaurants().ElementAt(id);
            return View(restaurant);
        }

        public ActionResult Details(int id)
        {
            var dish = _dataProvider.GetAllDishes().ElementAt(id);
            return View(dish);
        }
    }
}