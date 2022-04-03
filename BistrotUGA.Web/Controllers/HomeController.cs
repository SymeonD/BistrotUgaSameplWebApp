using BistrotUGA.Data.Models;
using BistrotUGA.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BistrotUGA.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IDishData _dishData;

        public HomeController(IDishData dataProvider)
        {
            _dishData = dataProvider;
        }

        public ActionResult Index()
        {
            var model = _dishData.GetAllRestaurants();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}