using Core.MernisAdapter;
using Core.Utilities.Results.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        //IResult Delete(int id);
        //IResult Update(int id);
        IResult Add(User user);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
    }
}
