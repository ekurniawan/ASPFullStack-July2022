using System.ComponentModel.DataAnnotations;

namespace MyASPProject.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirmation Password")]
        [Compare("Password",ErrorMessage ="Password dan Confirm Password tidak sama")]
        public string ConfirmPassword { get; set; }

    }
}
