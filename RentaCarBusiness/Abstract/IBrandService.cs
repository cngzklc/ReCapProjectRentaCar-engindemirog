using Core.Utilities.Results.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int brandId);
    }
}
