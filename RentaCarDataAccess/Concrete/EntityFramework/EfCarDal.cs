using Core.DataAccess.EntityFramework;
using RentaCarDataAccess.Abstract;
using RentaCarDataAccess.DTOs;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
