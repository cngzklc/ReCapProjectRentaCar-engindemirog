using Core.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using RentaCarBusiness.Abstract;
using RentaCarDataAccess.Abstract;
using RentaCarDataAccess.DTOs;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetById(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.CarId == id));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetNotRentableCars()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetNotRentableCars());
        }

        public IDataResult<List<Car>> GetRentableCars()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetRentableCars());
        }
        public IDataResult<List<Car>> GetRentableCars2()
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetRentableCars());
        }

        public IDataResult<List<CarDetailDto>> GetRentableCarsDto()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetRentableCarsDto());
        }
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.Added(car));
        }

        public IResult Delete(int id)
        {
            Car car = _carDal.Get(c => c.CarId == id);
            _carDal.Delete(car);
            return new SuccessResult(Messages.Added(car));
        }

        public IResult Update(int id)
        {
            Car car = _carDal.Get(c => c.CarId == id);
            _carDal.Update(car);
            return new SuccessResult(Messages.Added(car));
        }
    }
}
