using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım Arkadaşı İsmi Gereklidir,Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Bizimle Çalışan Arkadaşlarımızın Bir Görevi Olmalıdır");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Takım Arkadaşlarımızın Tipleri Bizim İçin Önemlidir");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen Adınzı İsa'nın Doğuşundaki dedelerinizden süregelecek şekilde oluturmayınız");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Lütfen İism Kısmına Soyadınızı da Yazdığınızdan Emin Olun");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage(" Görev Ve Sorumluluklarınızı Abartmayınız");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage(" O Kadar da Öldürmeyiniz");
        }
    }
}
