using RentaCarBusiness.Concrete;
using RentaCarDataAccess.Concrete.InMemory;
using RentaCarDataAccess.Concrete.EntityFramework;
using System;
using RentaCarEntities.Concrete;

namespace RentaCarUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarDetail();
            //CarTest();
            //BrandTest();
            Car car = new Car();
            car.CarName ="d";
            Console.WriteLine(car.CarName);
        }

        private static void CarDetail()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.Write("{0}{1}{2}{3}", "Brand Name".PadRight(15), "Car Name".PadRight(15), "Color".PadRight(15), "Daily Price\n");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.Write(car.BrandName.PadRight(15));
                Console.Write(car.CarName.PadRight(15));
                Console.Write(car.ColorName.PadRight(15));
                Console.Write(car.DailyPrice + "\n");
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
