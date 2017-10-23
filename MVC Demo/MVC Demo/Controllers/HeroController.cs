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
            IdentityModel model = new IdentityModel();
            var regions = GetAllRegions();

            model.TimeZonesModel = new TimeZonesModel();
            model.TimeZonesModel.Regions = GetSelectListItems(regions);
            return View(model);
        }

        [HttpPost]
        public ActionResult Submit(IdentityModel model)
        {
            if (!ModelState.IsValid)
            {
            }

            return View("Index", model);
        }

        [HttpPost]
        public ActionResult Submit2(IdentityModel model)
        {
            if (!ModelState.IsValid)
            {
            }

            return View("Index", model);
        }



        private IEnumerable<string> GetAllRegions()
        {
            return new List<string>
            {
                "Pacific",
                "Mountain",
                "Central",
                "Eastern"
            };
        }



        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        {
            // Create an empty list to hold result of the operation
            var selectList = new List<SelectListItem>();

            // For each string in the 'elements' variable, create a new SelectListItem object
            // that has both its Value and Text properties set to a particular value.
            // This will result in MVC rendering each item as:
            //     <option value="State Name">State Name</option>
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                });
            }

            return selectList;
        }
    }
}