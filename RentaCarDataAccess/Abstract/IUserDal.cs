using Core.DataAccess.Abstract;
using Core.Entities;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {

    }
}
