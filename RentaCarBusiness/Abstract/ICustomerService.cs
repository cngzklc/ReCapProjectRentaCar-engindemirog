using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetAllByUserId(int id);
    }
}
