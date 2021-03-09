using RentaCarDataAccess.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RentaCarDataAccess.Concrete.InMemory
{
    public class InMemoryUserDal : IUserDal
    {
        List<User> _users;
        public InMemoryUserDal()
        {
            _users = new List<User>()
            {
                new User(){ Id=1, FirstName = "Can", LastName = "Kılıç", NationalId = "25684900000", DateOfBirth = new DateTime(1985, 7, 8),   /* PasswordHash = "1234",*/Email = "cngzklc@gmail.com"},
                new User(){ Id=2, FirstName = "Çağan", LastName = "Kılıç", NationalId = "25684900001", DateOfBirth = new DateTime(1986, 7, 8), /* PasswordHash = "4567",*/Email = "cngzklc1@gmail.com"},
                new User(){ Id=3, FirstName = "Cengiz", LastName = "Kılıç", NationalId = "25684900002", DateOfBirth = new DateTime(1987, 7, 8),/* PasswordHash = "7890",*/Email = "cngzklc2@gmail.com"},
                new User(){ Id=4, FirstName = "Utku", LastName = "Kılıç", NationalId = "25684900003", DateOfBirth = new DateTime(1988, 7, 8),  /* PasswordHash = "4321",*/Email = "cngzklc3@gmail.com"},
            };
        }
        public void Add(User entity)
        {
            _users.Add(entity);
        }

        public void Delete(User entity)
        {
            User UserToDeleted = _users.SingleOrDefault(u => u.Id == entity.Id);
            _users.Remove(UserToDeleted);
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            var query = filter.Compile();
            return (User)_users.SingleOrDefault(query.Invoke);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            if (filter==null)
            {
                return _users;
            }
            else
            {
                var query = filter.Compile();
                return _users.Where(query.Invoke).ToList();
            }
        }

        public List<OperationClaim> GetClaims(User user)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            User UserToUpdated = _users.SingleOrDefault(u => u.Id == entity.Id);
            UserToUpdated.FirstName = entity.FirstName;
            UserToUpdated.LastName = entity.LastName;
            UserToUpdated.NationalId = entity.NationalId;
            UserToUpdated.PasswordHash = entity.PasswordHash;
            UserToUpdated.DateOfBirth = entity.DateOfBirth;
            UserToUpdated.Email = entity.Email;

        }
    }
}
