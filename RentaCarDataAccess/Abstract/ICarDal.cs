using RentaCarDataAccess.DTOs;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using Core.DataAccess.Abstract;

namespace RentaCarDataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> GetRentableCarsDto();
        List<Car> GetRentableCars();
        List<Car> GetRentableCars2();
        List<Car> GetNotRentableCars();
        
    }
}
