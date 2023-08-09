using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentatione.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string mail { get; set; }
        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        [Compare("password",ErrorMessage ="Şifrelerin eşleştiğinden emin olun")]
        public string password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        public string passwordConfirm { get; set; }
    }
}
