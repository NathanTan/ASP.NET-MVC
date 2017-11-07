using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Models
{
    public class HeroViewModel
    {
        public string Name { get; set; }
        public string HeroName { get; set; }
        public string SidekickName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string OriginCity { get; set; }
        public string Region { get; set; }
        public IEnumerable<SelectListItem> PossibleRegions { get; set; }
    }
}