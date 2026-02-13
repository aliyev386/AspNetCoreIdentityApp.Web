using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignUpViewModel
    {

        public SignUpViewModel(string userName, string email, string phone, string password, string passwordConfirm)
        {
            UserName = userName;
            Email = email;
            Phone = phone;
            Password = password;
            PasswordConfirm = passwordConfirm;
        }
        [Display(Name ="Kullanici Adi: ")]
        public string UserName { get; set; }
        [Display(Name ="Email: ")]
        public string Email { get; set; }
        [Display(Name ="Telefon: ")]
        public string Phone { get; set; }
        [Display(Name ="Sifre: ")]
        public string Password { get; set; }
        [Display(Name ="Sifre tekrar: ")]
        public string PasswordConfirm { get; set; }
    }
}
