using RentaCarDataAccess.Abstract;
using RentaCarEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Abstract
{
    public abstract class EntityService<T>
    {
        //EntityRepository<T> _entityDal;
        public EntityService()
        {

        }
        public virtual List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual List<T> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }
    }
}
