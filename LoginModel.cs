using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace ShopHub.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please Enter Username!")]
        [StringLength(100)]
        [Display(Name = "Username")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Please Enter Password!")]
        [StringLength(100)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
