using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısmı Boş Geçilemez!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez!")
                .Matches("[A-Z]").WithMessage("Parola da büyük harf olmak zorunda!")
                .Matches("[a-z]").WithMessage("Parola da küçük harf olmak zorunda!")
                .Matches("[0-9]").WithMessage("Parola da rakam  olmak zorunda!")
                .Matches("[^a-zA-Z0-9]").WithMessage("Parola da spesifik karakter olmak zorunda!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapınız!");
        }
    }
}
