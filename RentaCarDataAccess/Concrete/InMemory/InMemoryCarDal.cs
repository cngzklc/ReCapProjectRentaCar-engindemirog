using RentaCarDataAccess.Abstract;
using RentaCarDataAccess.DTOs;
using RentaCarEntities.Concrete;
using System;
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
                new Car {CarId =1, BrandId=1, ColorId=1, DailyPrice=700, ModelYear=2015, Description="Günlük kiralamaya uygun" },
                new Car {CarId =2, BrandId=1, ColorId=1, DailyPrice=600, ModelYear=2016, Description="Günlük kiralamaya uygun" },
                new Car {CarId =3, BrandId=1, ColorId=1, DailyPrice=500, ModelYear=2008, Description="Günlük kiralamaya uygun" },
                new Car {CarId =4, BrandId=2, ColorId=1, DailyPrice=500, ModelYear=2020, Description="Günlük kiralamaya uygun" },
                new Car {CarId =1, BrandId=6, ColorId=1, DailyPrice=250, ModelYear=2008, Description="Günlük kiralamaya uygun" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
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

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
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
    }
}
