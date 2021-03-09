using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Security.JWT;
using RentaCarDataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreteAccessToken(User user);

    }
}
