using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class HeroController : Controller
    {
        // GET: Hero
        [HttpGet]
        public ActionResult Index()
        {
            HeroViewModel model = new HeroViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(HeroViewModel data)
        {
            if (ModelState.IsValid)
            {
                return View("Accept", data);
            }
            return View(data);
        }
    }
}