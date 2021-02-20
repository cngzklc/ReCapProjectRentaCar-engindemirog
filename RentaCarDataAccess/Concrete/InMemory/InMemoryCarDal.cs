using RentaCarDataAccess.Abstract;
using RentaCarDataAccess.Comparer;
using RentaCarDataAccess.DTOs;
using RentaCarEntities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RentaCarDataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId =1, BrandId=1, ColorId=1, CarName = "A6", DailyPrice=700, ModelYear=2015, Description="Sedan, Otomatik" }, // teslim edilmedi
                new Car {CarId =2, BrandId=4, ColorId=6, CarName = "A180", DailyPrice=600, ModelYear=2016, Description="Hatchback, Otomatik" },
                new Car {CarId =3, BrandId=3, ColorId=4, CarName = "Mondeo", DailyPrice=500, ModelYear=2008, Description="Sedan, Manuel" },
                new Car {CarId =4, BrandId=2, ColorId=3, CarName = "1.16i", DailyPrice=500, ModelYear=2020, Description="Hatchback, Otomatik" },
                new Car {CarId =5, BrandId=6, ColorId=1, CarName = "Symbol", DailyPrice=250, ModelYear=2008, Description="Sedan, Manuel" }, // teslim edilmedi
                new Car {CarId =6, BrandId=4, ColorId=8, CarName = "E200", DailyPrice=500, ModelYear=2010, Description="Sedan, Manuel" },
                new Car {CarId =7, BrandId=3, ColorId=7, CarName = "Focus", DailyPrice=500, ModelYear=2018, Description="Sedan, Otomatik" },
                new Car {CarId =8, BrandId=2, ColorId=2, CarName = "5.25", DailyPrice=900, ModelYear=2020, Description="Sedan, Otomatik" },
                new Car {CarId =9, BrandId=6, ColorId=5, CarName = "Megan", DailyPrice=500, ModelYear=2017, Description="Hatchback, Otomatik" }
            };
        }
        public void Add(Car car)
        {
            if (car.CarName.Length < 2)
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalı!");

            }
            else
            {
                if (car.DailyPrice <= 0)
                {
                    Console.WriteLine("Günlük kiralama ücreti sıfırdan büyük olmalı!");
                }
                else
                {
                    _cars.Add(car);
                }
            }

        }
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }
        public Car Get(Expression<Func<Car, bool>> filter)
        {
            var query = filter.Compile();
            return (Car)_cars.SingleOrDefault(query.Invoke);
        }
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            if (filter == null)
            {
                return _cars;
            }
            else
            {
                var query = filter.Compile();
                return _cars.Where(query.Invoke).ToList();
            }
        }
        public List<CarDetailDto> GetCarDetails()
        {
            InMemoryBrandDal brandDal = new InMemoryBrandDal();
            InMemoryColorDal colorDal = new InMemoryColorDal();

            var resault = from c in GetAll()
                          join b in brandDal.GetAll() on c.BrandId equals b.BrandId
                          join o in colorDal.GetAll() on c.ColorId equals o.ColorId

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
        public List<Car> GetNotRentableCars()
        {
            InMemoryRentalDal inMemoryRentalDal = new InMemoryRentalDal();
            List<Rental> _rentals = inMemoryRentalDal.GetAll();

            var result = from c in _cars
                         join r in _rentals on c.CarId equals r.CarId
                         where r.ReturnDate == null

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

            return result.ToList();
        }
        public List<Car> GetRentableCars2() /*=> GetAll().Except(GetNotRentableCars()).ToList();*/
        { 
            return GetAll().Except(GetNotRentableCars(), new CarComparer()).ToList();
        }
        public List<Car> GetRentableCars() 
        {
            return  GetAll().Where(c => !GetNotRentableCars().Any(nrc => nrc.CarId == c.CarId)).ToList();
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<CarDetailDto> GetRentableCarsDto()
        {
            InMemoryBrandDal brandDal = new InMemoryBrandDal();
            InMemoryColorDal colorDal = new InMemoryColorDal();

            var resault = from c in GetAll()
                          join b in brandDal.GetAll() on c.BrandId equals b.BrandId
                          join o in colorDal.GetAll() on c.ColorId equals o.ColorId

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
}
