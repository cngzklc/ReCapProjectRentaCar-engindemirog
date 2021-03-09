using Core.Aspects.Autofac.Validation;
using Core.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using RentaCarBusiness.Abstract;
using RentaCarBusiness.ValidationRules.FluentValidation;
using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.Added(customer));
        }

        public IResult Delete(int id)
        {
            Customer customer = _customerDal.Get(c => c.Id == id);
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.Added(customer));
        }

        public IResult Update(int id)
        {
            Customer customer = _customerDal.Get(c => c.Id == id);
            _customerDal.Update(customer);
            return new SuccessResult(Messages.Added(customer));
        }
        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<List<Customer>> GetAllByUserId(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(p => p.UserId == id));
        }
    }
}
