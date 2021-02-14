using RentaCarBusiness.Concrete;
using RentaCarDataAccess.Concrete.InMemory;
using RentaCarDataAccess.Concrete.EntityFramework;
using System;
using RentaCarEntities.Concrete;
using Core.Constants;
using Core.MernisAdapter;
using Core.DataAccess.EntityFramework;

namespace RentaCarUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAdd();


            UserAdd();

            //MernisAdapterTest();


            //CarTest1();
            //CarDetail();
            //CarTest();
            //BrandTest();
            //Car car = new Car();
            //car.CarName ="d";
            //Console.WriteLine(car.CarName);
        }

        private static void MernisAdapterTest()
        {
            User user = new User()
            {
                FirstName = "Cengiz",
                LastName = "Kılıç",
                NationalId = "25684908800",
                DateOfBirth = new DateTime(1985, 7, 8),
                Password = "1234",
                Email = "cngzklc@gmail.com"
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
            EfUserDal efUserDal = new EfUserDal(new MernisServiceAdapter());
            efUserDal.Add(user);
            Console.WriteLine("Kişi eklenmiştir");
        }

        private static void CarAdd()
        {
            Car car = new Car()
            {
                //CarId = 7,
                BrandId = 4,
                CarName = "Brava",
                ColorId = 3,
                DailyPrice = 400,
                Description = "Hatchback, Otomatik",
                ModelYear = 2019
            };
            EfCarDal efCarDal = new EfCarDal();/*new EfEntityRepositoryBase(car, new RentaCarContext());*/
            efCarDal.Add(car);
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
            foreach (var car in carManager.GetCarDetails())
            {
                Console.Write("{0}{1}{2}{3}{4}\n", car.BrandName.PadRight(15), car.CarName.PadRight(15), car.ColorName.PadRight(15), car.DailyPrice.ToString().PadRight(15), car.Description);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
