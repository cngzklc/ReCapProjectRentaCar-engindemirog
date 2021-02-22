using Core.Utilities.Results.Abstract;
using RentaCarDataAccess.DTOs;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetAllCustomerId(int customerId);
        IResult RentableCar(int carId);
        IDataResult<Rental> GetById(int Id);
        IResult Add(Rental rental);
        IResult Delete(int id);
        IResult Update(int id);
        IDataResult<List<NotRentableCarDto>> GetNotRentableCarDetails();
    }
}
