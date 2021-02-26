using FluentValidation;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotEmpty().Matches(@"(@)(.+)$");
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.DateOfBirth).NotEmpty();
            RuleFor(u => u.NationalId).Length(11);
            RuleFor(u => u.Password).NotEmpty().Matches(@"^(?=.*[0 - 9])(?=.*[a - z])(?=.*[A - Z])(?=.*[*.!@$% ^&(){ } []:;<>,.?/ ~_ +-=|\]).{ 8,32}$");
        }
    }
}

/*
^                                            Dizenin başlangıcını eşleştir
(?=.*[0-9])                                  Dizenin herhangi bir yerinde en az bir rakamın görünmesini zorunlu kılın
(?=.*[a-z])                                  Dizenin herhangi bir yerinde en az bir küçük harf görünmesini zorunlu kılın
(?=.*[A-Z])                                  Dizenin herhangi bir yerinde en az bir büyük harfin görünmesini zorunlu kılın
(?=.*[*.!@$%^&(){}[]:;<>,.?/ ~_ +-=|\])      Dizenin herhangi bir yerinde en az bir özel karakterin görünmesini zorunlu kılın
.{8,32}                                      Şifre en az 8 karakter uzunluğunda olmalı, 32'den fazla olmamalıdır
$                                            Dizenin sonunu eşleştirin.
*/

