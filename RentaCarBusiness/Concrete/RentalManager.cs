using RentaCarBusiness.Abstract;
using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public List<Rental> GetAlCustomerId(int customerId)
        {
            return _rentalDal.GetAll(r => r.CustomerId == customerId);
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public List<Rental> GetAllCarId(int carId)
        {
            return _rentalDal.GetAll(r => r.CarId == carId);
        }
    }
}
