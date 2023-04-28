using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule.ContactUs
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("İçerik alanı boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj alanı boş geçilemez");
            RuleFor(x => x.Mail).EmailAddress();
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("Mail alanına en az 5 karakter girişi yapmanız gerekmektedir");
            RuleFor(x => x.Mail).MaximumLength(100).WithMessage("Mail alanına en fazla 100 karakter girişi yapmanız gerekmektedir");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("İçerik alanına en az 5 karakter girişi yapmanız gerekmektedir");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("İçerik alanına en fazla 100 karakter girişi yapmanız gerekmektedir");
        }
    }
}
