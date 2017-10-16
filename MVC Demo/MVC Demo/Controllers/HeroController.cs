using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Models
{
    public class HeroController : Controller
    {
        // GET: Hero/Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Submit(IdentityModel model)
        {
            if (ModelState.IsValid)
            {

            }

            return View("Index", model);
        }
    }
}