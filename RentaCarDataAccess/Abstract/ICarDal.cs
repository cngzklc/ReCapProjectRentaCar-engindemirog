using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
    }
}
