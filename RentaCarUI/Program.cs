using RentaCarBusiness.Concrete;
using RentaCarDataAccess.Concrete.InMemory;
using RentaCarDataAccess.Concrete.EntityFramework;
using System;
using RentaCarEntities.Concrete;
using Core.Constants;
using Core.MernisAdapter;
using Core.DataAccess.EntityFramework;
using RentaCarDataAccess.DTOs;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace RentaCarUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAdd();
            //UserAdd();
            //RentalAdd();

            //Rental_NotRentableCarsDetails();
            CarAdd();

            //RentableCars();
            //MernisAdapterTest();


            //CarTest1();
            //CarDetail();
            //CarTest();
            //BrandTest();
            //Car car = new Car();
            //car.CarName ="d";
            //Console.WriteLine(car.CarName);
        }
       static void RentableCars()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            int i = 0;
            foreach (var item in carManager.GetRentableCarsDto().Data)
            {
                i++;
                Console.WriteLine("{5} - {0}{1}{2}{3}{4}", item.BrandName.PadRight(10), item.CarName.PadRight(10), item.ColorName.PadRight(10), item.DailyPrice.ToString().PadRight(10), item.Description.PadRight(20), i);
            }
        }
        private static void Rental_NotRentableCarsDetails()
        {
            RentalManager rentalManager = new RentalManager(new InMemoryRentalDal());

            List<NotRentableCarDto> rentableCars = rentalManager.GetNotRentableCarDetails().Data;

            foreach (var item in rentableCars)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{5}",
                    item.BrandName.PadRight(10),
                    item.CarName.PadRight(10),
                    item.Description.PadRight(20),
                    item.CompanyName.PadRight(15),
                    item.FirstName.PadRight(10),
                    item.LastName.PadRight(10));
            }
        }
        private static void RentalAdd()
        {
            EfRentalDal efRentalDal = new EfRentalDal();
            RentalManager rentalManager = new RentalManager(efRentalDal);
            Rental rental = new Rental() { CustomerId = 1, CarId = 1, RentDate = DateTime.Now.Date, ReturnDate = null };
            rentalManager.Add(rental);
            string message = rentalManager.Add(rental).Message;
            Console.WriteLine(message);
        }
        private static void MernisAdapterTest()
        {
            User user = new User()
            {
                FirstName = "Cengiz",LastName = "Kılıç",NationalId = "25684908800",DateOfBirth = new DateTime(1985, 7, 8),Password = "1234",Email = "cngzklc@gmail.com"
            };
            MernisServiceAdapter mernisServiceAdapter = new MernisServiceAdapter();
            var resaultt = mernisServiceAdapter.CheckIfRealPerson(user);
            Console.WriteLine(resaultt);
        }
        private static void UserAdd()
        {
            User user = new User()
            {
                FirstName = "Cimcime",
                LastName = "Kılıç",
                NationalId = "20120111206",
                DateOfBirth = new DateTime(2014, 08, 30).Date,
                Password = "1234",
                Email = "eylulll.kilic@gmail.com"
            };
            EfUserDal efUserDal = new EfUserDal();
            UserManager userManager = new UserManager(efUserDal);
            Console.WriteLine(userManager.Add(user).Message);

            //Console.WriteLine("Kişi eklenmiştir");
        }
        private static void CarAdd()
        {
            Car car = new Car()
            {
                //CarId = 7,
                BrandId = 5,
                CarName = "CLK 200",
                ColorId = 3,
                DailyPrice = 800,
                Description = "Hatchback, Otomatik",
                ModelYear = 2020
            };
            EfCarDal efCarDal = new EfCarDal();/*new EfEntityRepositoryBase(car, new RentaCarContext());*/
            efCarDal.Add(car);
        }
        private static void CarAddInMemoryDal()
        {
            Car car = new Car()
            {
                CarId = 10,
                BrandId = 5,
                CarName = "Brava",
                ColorId = 3,
                DailyPrice = 400,
                Description = "Hatchback, Otomatik",
                ModelYear = 2019
            };
            Car car1 = new Car()
            {
                CarId = 11,
                BrandId = 4,
                CarName = "CLK 200",
                ColorId = 1,
                DailyPrice = 800,
                Description = "Hatchback, Otomatik",
                ModelYear = 2020
            };
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();/*new EfEntityRepositoryBase(car, new RentaCarContext());*/
            CarManager carManager = new CarManager(inMemoryCarDal);
            inMemoryCarDal.Add(car);
            inMemoryCarDal.Add(car1);
            int i = 0;
            foreach (var item in carManager.GetRentableCarsDto().Data)
            {
                i++;
                Console.WriteLine("{5} - {0}{1}{2}{3}{4}", item.BrandName.PadRight(10), item.CarName.PadRight(10), item.ColorName.PadRight(10), item.DailyPrice.ToString().PadRight(10), item.Description.PadRight(20), i);
            }
        }
        private static void CarTest1()
        {
            Car car = new Car() { CarId = 7, BrandId = 4, CarName = "fgdfg", ColorId = 6, DailyPrice = 200, Description = "Hatchback Sedan", ModelYear = 2015 };
            Console.WriteLine(Messages.Added(car));
        }
        private static void CarDetail()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.Write("{0}{1}{2}{3}{4}", "Brand Name".PadRight(15), "Car Name".PadRight(15), "Color".PadRight(15), "Daily Price".PadRight(15), "Description\n");
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.Write("{0}{1}{2}{3}{4}\n", car.BrandName.PadRight(15), car.CarName.PadRight(15), car.ColorName.PadRight(15), car.DailyPrice.ToString().PadRight(15), car.Description);
            }
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
