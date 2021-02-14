using Core.DataAccess.EntityFramework;
using Core.Entities;
using Core.MernisAdapter;
using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentaCarContext>, IUserDal
    {
        IPersonCheckService _personCheckService;
        public EfUserDal(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public override void Add(User entity)
        {
            if (_personCheckService.CheckIfRealPerson(entity))
            {
                base.Add(entity);
            }
            else
            {
                throw new Exception("Girişi yapılan kişinin Mernis doğrulaması yapılamamıştır.\nLütfen kimlik bilgilerini kontrol ediniz!");
            }
        }

    }
}
