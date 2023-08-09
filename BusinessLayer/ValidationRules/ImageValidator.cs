using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel Başlığını Boş Geçemezsiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel Açıklamasını Boş Geçemezsiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Yolunu Boş Geçemezsiniz");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Lütfen En Az 8 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Lütfen En Fazla 50 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Lütfen En Az 20 Karakter Veri Girişi Yapınız");
        }
    }
}
