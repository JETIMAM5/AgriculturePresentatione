using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentatione.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin")]
        public string username  { get; set; }
        [Required(ErrorMessage ="Lütfen Şifre Giriniz")]
        public string password { get; set; }
    }
}
