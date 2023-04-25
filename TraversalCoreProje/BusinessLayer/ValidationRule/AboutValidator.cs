using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz");
            RuleFor(X => X.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz");
            RuleFor(X => X.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karaktelik açıklama bilgisi giriniz...!!!");
            RuleFor(X => X.Description).MaximumLength(1500).WithMessage("Lütfen açıklamay kısalt...!!!");
        }
    }
}
