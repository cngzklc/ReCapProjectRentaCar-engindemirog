using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.Comparer
{
    public class CarComparer : IEqualityComparer<Car>
    {
        public bool Equals(Car car1, Car car2)
        {
            if (ReferenceEquals(car1, car2)) return true;

            //Check whether any of the compared objects is null.
            if (ReferenceEquals(car1, null) || ReferenceEquals(car2, null))
                return false;

            //Check whether the products' properties are equal.
            return car1.CarId == car2.CarId &&
                car1.BrandId == car2.BrandId &&
                car1.CarName == car2.CarName &&
                car1.ColorId == car2.ColorId &&
                car1.DailyPrice == car2.DailyPrice &&
                car1.Description == car2.Description &&
                car1.ModelYear == car2.ModelYear;
        }

        public int GetHashCode(Car car)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(car, null)) return 0;

            //Get hash code for the Name field if it is not null.
            int hashCarName = car.CarName == null ? 0 : car.CarName.GetHashCode();

            //Get hash code for the Code field.
            int hashCarId = car.CarId.GetHashCode();

            //Calculate the hash code for the product.
            return hashCarName ^ hashCarId;
        }
    }
}
