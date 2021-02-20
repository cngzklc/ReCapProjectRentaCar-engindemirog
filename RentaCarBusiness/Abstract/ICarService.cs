using Core.Utilities.Results.Abstract;
using RentaCarDataAccess.DTOs;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<Car>> GetNotRentableCars();
        IDataResult<List<Car>> GetRentableCars();
        IDataResult<List<CarDetailDto>> GetRentableCarsDto();
        IDataResult<List<Car>> GetRentableCars2();

    }
}
