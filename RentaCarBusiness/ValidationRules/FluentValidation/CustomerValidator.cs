using FluentValidation;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.ValidationRules.FluentValidation
{
    class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).NotEmpty();//CompanyName boş olamaz
            RuleFor(c => c.UserId).NotEmpty(); //UserId boş olamaz.
        }
    }
}
