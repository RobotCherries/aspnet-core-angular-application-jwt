using System.ComponentModel.DataAnnotations;

namespace ng_core_auth.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
