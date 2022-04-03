using BistrotUGA.Data.Models;
using BistrotUGA.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BistrotUGA.Web.Controllers
{
    public class MenuController : Controller
    {
        private readonly IDishData _dataProvider;

        public MenuController(IDishData dataProvider)
        {
            _dataProvider = dataProvider;
        }
        

        // GET: Menu/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: Menu/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BistrotDish dishItem)
        {
           
            try
            {

                if (String.IsNullOrEmpty(dishItem.Name))
                {
                    ModelState.AddModelError(nameof(dishItem.Name), "You have to give the plat a name!");
                }


                if (ModelState.IsValid)
                {
                    // Do some bussiness logic here
                    _dataProvider.AddDish(dishItem);
                }

          
                return View();
            }
            catch
            {
                return View();
            }
        }

    }
}
