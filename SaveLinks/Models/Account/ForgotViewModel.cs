using System.ComponentModel.DataAnnotations;

namespace SaveLinks.Models.Account
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}