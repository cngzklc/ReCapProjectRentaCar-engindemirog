using FluentValidation;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty(); //Brand name boş olamaz.
            RuleFor(b => b.BrandName).MinimumLength(2); //Brand name iki karakterden küçük olamaz kuralı ekliyoruz.

        }
    }
}
