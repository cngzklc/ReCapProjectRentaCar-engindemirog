using RentaCarBusiness.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Concrete
{
    public abstract class EntityManager<T> 
    {

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }
    }
}
