using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
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
                new User(){ UserId=1, FirstName = "Can", LastName = "Kılıç", NationalId = "25684900000", DateOfBirth = new DateTime(1985, 7, 8), Password = "1234",Email = "cngzklc@gmail.com"},
                new User(){ UserId=2, FirstName = "Çağan", LastName = "Kılıç", NationalId = "25684900001", DateOfBirth = new DateTime(1986, 7, 8), Password = "4567",Email = "cngzklc1@gmail.com"},
                new User(){ UserId=3, FirstName = "Cengiz", LastName = "Kılıç", NationalId = "25684900002", DateOfBirth = new DateTime(1987, 7, 8), Password = "7890",Email = "cngzklc2@gmail.com"},
                new User(){ UserId=4, FirstName = "Utku", LastName = "Kılıç", NationalId = "25684900003", DateOfBirth = new DateTime(1988, 7, 8), Password = "4321",Email = "cngzklc3@gmail.com"},
            };
        }
        public void Add(User entity)
        {
            _users.Add(entity);
        }

        public void Delete(User entity)
        {
            User UserToDeleted = _users.SingleOrDefault(u => u.UserId == entity.UserId);
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

        public void Update(User entity)
        {
            User UserToUpdated = _users.SingleOrDefault(u => u.UserId == entity.UserId);
            UserToUpdated.FirstName = entity.FirstName;
            UserToUpdated.LastName = entity.LastName;
            UserToUpdated.NationalId = entity.NationalId;
            UserToUpdated.Password = entity.Password;
            UserToUpdated.DateOfBirth = entity.DateOfBirth;
            UserToUpdated.Email = entity.Email;

        }
    }
}
