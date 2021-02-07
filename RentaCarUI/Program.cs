using RentaCarBusiness.Concrete;
using RentaCarDataAccess.Concrete.InMemory;
using RentaCarDataAccess.Concrete.EntityFramework;
using System;

namespace RentaCarUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
