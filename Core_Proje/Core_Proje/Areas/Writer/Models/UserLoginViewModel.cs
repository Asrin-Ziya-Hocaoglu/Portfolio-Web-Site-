using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name="User Name")]
        [Required(ErrorMessage = "Please enter your user name .")]
        public string UserName { get; set; }
        [Display(Name="Password")]
        [Required(ErrorMessage ="Please enter your password.")]
        public string Password { get; set; }
    }
}
