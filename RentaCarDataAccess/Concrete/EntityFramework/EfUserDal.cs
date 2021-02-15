using Core.DataAccess.EntityFramework;
using Core.Entities;
using Core.MernisAdapter;
using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentaCarContext>, IUserDal
    {

    }
}
