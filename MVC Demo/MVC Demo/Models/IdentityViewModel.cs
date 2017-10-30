using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVC_Demo.Models
{
    public class IdentityViewModel
    {
        public string Name { get; set; }

        [Required]
        [Display(Name = "Hero Name")]
        public string HeroName { get; set; }

        [Display(Name = "Origin City")]
        public string OriginCity { get; set; }

        [Display(Name = "Side Kick Name")]
        public string SideKickName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [UIHint("Email")]
        public string Email { get; set; }

        [Required]
        [Range(18, 9999, ErrorMessage = "Must be at least 18 to register")]
        [UIHint("Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name="Time Zone")]
        [UIHint("TimeZonesModel")]
        public string Region { get; set; }

        public IEnumerable<SelectListItem> PossibleRegions { get; set; } = new List<SelectListItem>() {
            new SelectListItem()
            {
                Value = "Pacific",
                Text = "Pacific Time",
                Selected = false
            },
            new SelectListItem()
            {
                Value = "Mountain",
                Text = "Mountain Time",
                Selected = false
            },
            new SelectListItem()
            {
                Value = "Central",
                Text = "Central Time",
                Selected = false
            },
            new SelectListItem()
            {
                Value = "Eastern",
                Text = "Eastern Time",
                Selected = false
            }
        };
        
    }
}