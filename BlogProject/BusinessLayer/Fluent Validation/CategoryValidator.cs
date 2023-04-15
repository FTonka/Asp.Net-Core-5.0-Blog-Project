using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Fluent_Validation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklaması boş geçilemez");
            RuleFor(x => x.CategoryDescription).MaximumLength(500).WithMessage("Kategori açıklaması en fazla 500 karakter içerebilir.");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Kategori açıklaması en az 2 kelime içerebilir.");
        }
    }
}
