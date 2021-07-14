using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LearningCoding.Models
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
