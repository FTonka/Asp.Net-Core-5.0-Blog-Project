using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Fluent_Validation
{
	public class WriterValidator:AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("İsim uzunluğu 2 karakterden az olamaz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("İsim uzunluğu 50 karakterden fazla olamaz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
        }

    }
}
