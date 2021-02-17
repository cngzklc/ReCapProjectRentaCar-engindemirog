using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RentaCarDataAccess.Concrete.InMemory
{
    public class InMemoryCustomerDal : ICustomerDal
    {
        List<Customer> _customers;
        public InMemoryCustomerDal()
        {
            _customers = new List<Customer>()
                {
                    new Customer() { CustomerId=1, UserId=1, CompanyName= "Cengiz A.Ş"},
                    new Customer() { CustomerId=2, UserId=2, CompanyName= "Kazım A.Ş"},
                    new Customer() { CustomerId=3, UserId=3, CompanyName= "Cengiz A.Ş"},
                    new Customer() { CustomerId=4, UserId=4, CompanyName= "Deniz A.Ş"}
                };
        }
        public void Add(Customer entity)
        {            
            _customers.Add(entity);
        }

        public void Delete(Customer entity)
        {
            Customer CustomerToDelete = _customers.SingleOrDefault(c => c.CustomerId == entity.CustomerId);
            _customers.Remove(CustomerToDelete);
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            var query = filter.Compile();
            return (Customer)_customers.SingleOrDefault(query.Invoke);
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            if (filter == null)
            {
                return _customers;
            }
            else
            {
                var query = filter.Compile();
                return _customers.Where(query.Invoke).ToList();
            }
        }

        public void Update(Customer entity)
        {
            Customer CustomerToUpdated = _customers.SingleOrDefault(c => c.CustomerId == entity.CustomerId);
            CustomerToUpdated.CompanyName = entity.CompanyName;
            CustomerToUpdated.UserId = entity.UserId;
        }
    }
}
