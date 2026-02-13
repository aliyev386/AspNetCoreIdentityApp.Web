using Microsoft.AspNetCore.Authorization.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignUpViewModel
    {
        public SignUpViewModel() { }
        public SignUpViewModel(string userName, string email, string phone, string password, string passwordConfirm)
        {
            UserName = userName;
            Email = email;
            Phone = phone;
            Password = password;
            PasswordConfirm = passwordConfirm;
        }

        [Required(ErrorMessage = "Kullanici ad bos birakilamaz.")]
        [Display(Name ="Kullanici Adi :")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage ="Email formati yalnistir.")]
        [Required(ErrorMessage = "Email bos birakilamaz.")]
        [Display(Name ="Email :")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon bos birakilamaz.")]
        [Display(Name ="Telefon :")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Sifre bos birakilamaz.")]
        [Display(Name ="Sifre :")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Sifre tekrar bos birakilamaz.")]
        [Compare("Password", ErrorMessage = "Sifre ayni digildir.")]
        [Display(Name ="Sifre tekrar :")]
        public string PasswordConfirm { get; set; }
    }
}
