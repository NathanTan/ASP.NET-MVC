using System.ComponentModel.DataAnnotations;

namespace MVC_Demo.Models
{
    public class IdentityModel
    {
        public string Name;
        public string HeroName;
        public string OriginCity;
        public string SideKickName;
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Range(18, 9999999999)]
        public int Age { get; set; }
    }
}