using System.ComponentModel.DataAnnotations;

namespace MVC_Demo.Models
{
    public class IdentityModel
    {
        [Required]
        public string Name { get; set; }

        [Display(Name = "Hero Name")]
        public string HeroName { get; set; }

        [Display(Name = "Origin City")]
        public string OriginCity { get; set; }

        [Display(Name = "Side Kick Name")]
        public string SideKickName { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Range(18, 9999999999, ErrorMessage = "Must be at least 18 to registar")]
        public int Age { get; set; }
    }
}