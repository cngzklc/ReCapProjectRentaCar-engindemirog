using Core.MernisAdapter;
using Core.Utilities.Results.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User user, IPersonCheckService personCheckService);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
