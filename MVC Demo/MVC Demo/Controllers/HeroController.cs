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
            IdentityViewModel model = new IdentityViewModel();
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Submit(IdentityViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Name == null)
                    model.Name = "[unspecified]";
                if (model.OriginCity == null) 
                    model.OriginCity = "[unspecified]";
                if (model.SideKickName == null)
                    model.SideKickName = "[unspecified]";

                return View("Accepted", model);
            }

            return View("Index", model);
        }
    }
}