using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentaCarDataAccess.Concrete.InMemory
{
    class InMemoryCarDal : ICarDal_Alternatif
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

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetById(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
