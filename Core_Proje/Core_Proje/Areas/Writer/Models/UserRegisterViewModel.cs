using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your surname.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter your user name.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your password.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter your password again.")]
        [Compare("Password",ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please enter your E-mail.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Please enter your image url value.")]
        public string ImageUrl { get; set; }



    }
}
