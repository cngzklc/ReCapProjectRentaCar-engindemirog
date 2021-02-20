using Core.DataAccess.Abstract;
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
    public class InMemoryRentalDal : IRentalDal
    {
     List<Rental> _rentals;
        public InMemoryRentalDal()
        {
            _rentals = new List<Rental>()
            {
                new Rental() {RentalId=1, CarId=1, CustomerId=1, RentDate=new DateTime(2021,2,15).Date, ReturnDate= new DateTime(2021,2,17).Date },
                new Rental() {RentalId=2, CarId=1, CustomerId=2, RentDate=new DateTime(2021,2,17).Date, ReturnDate= null },            
                new Rental() {RentalId=3, CarId=3, CustomerId=1, RentDate=new DateTime(2021,2,10).Date, ReturnDate= new DateTime(2021,2,14).Date },
                new Rental() {RentalId=4, CarId=5, CustomerId=1, RentDate=new DateTime(2021,2,01).Date, ReturnDate= null },            
                new Rental() {RentalId=5, CarId=2, CustomerId=2, RentDate=new DateTime(2021,2,15).Date, ReturnDate= new DateTime(2021,2,17).Date },
                new Rental() {RentalId=6, CarId=1, CustomerId=1, RentDate=new DateTime(2021,2,15).Date, ReturnDate= new DateTime(2021,2,17).Date },
                new Rental() {RentalId=7, CarId=1, CustomerId=1, RentDate=new DateTime(2021,2,15).Date, ReturnDate= new DateTime(2021,2,17).Date }
            };
        }

        public void Add(Rental rental)
        {
            _rentals.Add(rental);
        }

        public void Delete(Rental rental)
        {
            Rental rentalToDelete = _rentals.SingleOrDefault(b => b.RentalId == rental.RentalId);
            _rentals.Remove(rentalToDelete);
        }

        public Rental Get(Expression<Func<Rental, bool>> filter)
        {
            var query = filter.Compile();
            return (Rental)_rentals.SingleOrDefault(query.Invoke);
        }

        public List<Rental> GetAll(Expression<Func<Rental, bool>> filter = null)
        {
            if (filter == null)
            {
                return _rentals;
            }
            else
            {
                var query = filter.Compile();
                return _rentals.Where(query.Invoke).ToList();
            }
        }

        public List<NotRentableCarDto> GetNotRentableCarDetails()
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            InMemoryBrandDal inMemoryBrandDal = new InMemoryBrandDal();
            InMemoryCustomerDal inMemoryCustomerDal = new InMemoryCustomerDal();
            InMemoryUserDal inMemoryUserDal = new InMemoryUserDal();

            List<Car> _cars = inMemoryCarDal.GetAll();
            List<Brand> _brands = inMemoryBrandDal.GetAll();
            List<Customer> _customers = inMemoryCustomerDal.GetAll();
            List<User> _users = inMemoryUserDal.GetAll();

                var result = from c in _cars
                             join r in _rentals on c.CarId equals r.CarId  where r.ReturnDate == null
                             join cu in _customers on r.CustomerId equals cu.CustomerId
                             join u in _users on cu.UserId equals u.UserId
                             join b in _brands on c.BrandId equals b.BrandId

                             select new NotRentableCarDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 Description = c.Description,
                                 CompanyName = cu.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName=u.LastName,
                                 ReturnDate = r.ReturnDate                                 
                             } ;
            return result.ToList();
            
        }

        public void Update(Rental rental)
        {
            Rental rentalToUpdate = _rentals.SingleOrDefault(b => b.RentalId == rental.RentalId);
            rentalToUpdate.CarId = rental.CarId;
            rentalToUpdate.CustomerId = rental.CustomerId;
            rentalToUpdate.RentDate = rental.RentDate;
            rentalToUpdate.ReturnDate = rental.ReturnDate;
        }
    }
}
