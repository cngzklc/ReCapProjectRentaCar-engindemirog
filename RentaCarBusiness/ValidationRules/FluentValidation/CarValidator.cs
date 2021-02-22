using FluentValidation;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.ValidationRules.FluentValidation
{
    public class CarValidator: AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandId).NotEmpty(); //BrandId boş olamaz kuralı
            RuleFor(c => c.ColorId).NotEmpty(); //ColorId boş olamaz kuralı
            RuleFor(c => c.DailyPrice).GreaterThan(0); //Günlük ücreti 0'dan büyük olmalı kuralı
            RuleFor(c => c.CarName).NotEmpty(); //CarName boş olamaz kuralı;
            RuleFor(c => c.CarName).Must(DoesNotContainSpaces).WithMessage("CarName içerisinde boşluk olmamalı"); // Must metodu ile DoesNotContainSpaces gibi kendi metodlarımızı kural haline getirebiliyoruz. Boşluk içermemeli kuralı
            RuleFor(c => c.CarName).MinimumLength(2); //CarName iki karakterden büyük olmalı
        }

        private bool DoesNotContainSpaces(string arg)
        {
            return !arg.Contains(" ");
        }
    }
}
