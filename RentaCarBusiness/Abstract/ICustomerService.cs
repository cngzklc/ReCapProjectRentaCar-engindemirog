using Core.Utilities.Results.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetAllByUserId(int id);
        IDataResult<Customer> GetById(int id);
        IResult Add(Customer customer);
        IResult Delete(int id);
        IResult Update(int id);
    }
}
