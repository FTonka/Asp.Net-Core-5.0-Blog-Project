using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Fluent_Validation
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlık alanı boş geçilemez");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş bırakılamaz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Reis bu blogun resmi yok mu?");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Başlık uzunluğu 5 harften az olamaz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Başlık uzunluğu 150 harften fazla olamaz");
			RuleFor(x => x.CategoryID).NotEmpty().WithMessage("Kategori ID'si boş geçilemez...");

		}
    }
}
