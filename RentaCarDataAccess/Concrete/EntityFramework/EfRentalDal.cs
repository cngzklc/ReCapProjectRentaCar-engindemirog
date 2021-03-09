using Core.DataAccess.EntityFramework;
using RentaCarDataAccess.Abstract;
using RentaCarDataAccess.DTOs;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RentaCarDataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentaCarContext>, IRentalDal
    {
        public List<NotRentableCarDto> GetNotRentableCarDetails()
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join r in context.Rentals on c.Id equals r.CarId where r.ReturnDate == null
                             join cu in context.Customers on r.CustomerId equals cu.Id
                             join u in context.Users on cu.UserId equals u.Id


                             select new NotRentableCarDto
                             {
                                 CarId = c.Id,
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 Description = c.Description,
                                 CompanyName = cu.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();

            }
        }
    }
}
