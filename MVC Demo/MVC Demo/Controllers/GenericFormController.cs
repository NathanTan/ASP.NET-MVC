﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Models
{
    public class GenericFormController : Controller
    {
        // GET: GenericForm
        public ActionResult Index()
        {
            var model = new FormModel();

            return View(model);
        }

        public ActionResult GenericForm()
        {
            ViewBag.Message = "Please fill out the following form";

            return View();
        }
    }
}