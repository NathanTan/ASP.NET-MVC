using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult GenericForm(FormModel model)
        {
            ViewBag.Message = "Please fill out the following form";

            return View();
        }

        public ActionResult SubmitForm(FormModel model)
        {

            return View();
        }


        [HttpPost]
        public ActionResult Submit(FormModel model)
        {

            // If we got this far, something failed, redisplay form
            return View(model);
        }
    }
}