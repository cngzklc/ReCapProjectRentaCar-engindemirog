using Core.DataAccess.EntityFramework;
using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, RentaCarContext>, ICarImageDal
    {
        public List<CarImage> GetCarImages(int CarId)
        {
            return GetAll(c => c.CarId == CarId);
        }
    }
}
