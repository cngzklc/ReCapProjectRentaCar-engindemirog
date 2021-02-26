using Core.Aspects.Autofac.Validation;
using Core.Constants;
using Core.Entities;
using Core.MernisAdapter;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using RentaCarBusiness.Abstract;
using RentaCarBusiness.ValidationRules.FluentValidation;
using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentaCarBusiness.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            IResult result = BusinessRules.Run(CheckIfNationalIdExists(user.NationalId), CheckIfRealPerson(user));
            if (!result.Success)
            {
                return new ErrorResult(Messages.Invalid(user));

            }
            _userDal.Add(user);
            return new SuccessResult(Messages.Added(user));
        }
        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == id));
        }
        public IResult Delete(int id)
        {
            User user = _userDal.Get(u => u.UserId == id);
            _userDal.Delete(user);
            return new SuccessResult(Messages.Deleted(user));
        }
        public IDataResult<List<User>> GetAll()
        {
            //if (_userDal.GetAll().Equals(null))
            //{
            //    return new  ErrorDataResult<List<User>>(_userDal.GetAll(),Messages.NotListed(new List<User>()));
            //}
            //else
            //{
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
            //}
        }

        public IResult Update(int id)
        {
            User user = _userDal.Get(u => u.UserId == id);
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated(user));
        }

        IResult CheckIfRealPerson(User user)
        {
            MernisServiceAdapter mernisServiceAdapter = new MernisServiceAdapter();
            if (!mernisServiceAdapter.CheckIfRealPerson(user))
            {
                return new ErrorResult(Messages.NotRealPerson);
            }
            return new SuccessResult();
        }
        IResult CheckIfNationalIdExists(string nationalId)
        {
            var result = _userDal.GetAll(c => c.NationalId == nationalId).Any();
            if (result)
            {
                return new ErrorResult(Messages.NationalIdExisted);
            }
            else
            {
                return new SuccessResult();
            }
        }
    }
}
