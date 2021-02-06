using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : BaseEntityRepository<Brand>, IBrandDal
    {

    }
}
