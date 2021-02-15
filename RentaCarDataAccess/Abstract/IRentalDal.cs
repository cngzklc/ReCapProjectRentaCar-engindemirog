using Core.DataAccess.Abstract;
using RentaCarDataAccess.DTOs;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<RentableCarDto> GetRentableCars();
    }
}
