using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Abstract
{
    public interface IRentalService
    {
        List<Rental> GetAll();
        List<Rental> GetAlCustomerId(int customerId);
        List<Rental> GetAllCarId(int carId);
    }
}
