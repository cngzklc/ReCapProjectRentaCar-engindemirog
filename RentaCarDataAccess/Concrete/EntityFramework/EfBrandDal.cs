using Core.DataAccess.EntityFramework;
using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;

namespace RentaCarDataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, NorthwindContext>, IBrandDal
    {

    }
}
