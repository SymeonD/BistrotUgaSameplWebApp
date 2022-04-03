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
    public class CategoryController : Controller
    {
        private readonly IDishData _dataProvider;


        // Simple Mapper
        private Dictionary<int, MenuType> _simpleMapper = new Dictionary<int, MenuType>() {
            { 0, MenuType.Entree },
            { 1, MenuType.Plat },
            { 2, MenuType.Dessert},
            { 3, MenuType.FruitdeMer },
            { 4, MenuType.Boisson},
            { 5, MenuType.Glace }
        };

        public CategoryController(IDishData dataProvider)
        {
            _dataProvider = dataProvider;
        }


        public ActionResult Details(int id)
        {
            var category = new DishCategory(_simpleMapper[id],
                                            _simpleMapper[id].ToString(),
                                            _dataProvider.GetDishesByCategory(_simpleMapper[id]));

            return View(category);
        }


     
    }
}