using Core.DataAccess.EntityFramework;
using RentaCarDataAccess.Abstract;
using RentaCarDataAccess.DTOs;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RentaCarDataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentaCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var resault = from c in context.Cars
                              join b in context.Brands on c.BrandId equals b.BrandId
                              join o in context.Colors on c.ColorId equals o.ColorId

                              select new CarDetailDto
                              {
                                  CarName = c.CarName,
                                  BrandName = b.BrandName,
                                  ColorName = o.ColorName,
                                  DailyPrice = c.DailyPrice,
                                  Description = c.Description
                              };
                return resault.ToList();
            }
        }
        public List<Car> GetRentableCars()
        {
            List<Car> _cars = GetAll();
            List<Car> _notRentableCars = GetNotRentableCars();
            List<Car> _rentableCars = _cars.Except(_notRentableCars).ToList();
            return _rentableCars;
            
        }
        public List<Car> GetNotRentableCars()
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var resault = from c in context.Cars
                              join r in context.Rentals on c.CarId equals r.CarId where r.ReturnDate == null
                              join o in context.Colors on c.ColorId equals o.ColorId

                              select new Car
                              {
                                  CarId = c.CarId,
                                  BrandId = c.BrandId,
                                  ColorId = c.ColorId,
                                  CarName = c.CarName,
                                  ModelYear = c.ModelYear,
                                  DailyPrice = c.DailyPrice,
                                  Description = c.Description
                              };
                return resault.ToList();
            }
        }
    }
}
