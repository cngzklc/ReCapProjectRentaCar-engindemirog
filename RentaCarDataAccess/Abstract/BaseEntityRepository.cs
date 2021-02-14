using Microsoft.EntityFrameworkCore;
using RentaCarDataAccess.Concrete.EntityFramework;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.Abstract;
using Core.MernisAdapter;

namespace RentaCarDataAccess.Abstract
{
    public abstract class BaseEntityRepository<T> : IPersonCheckService, IEntityRepository<T> where T : class, IEntity, new()
    {
        public virtual void Add(T entity)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public virtual void Delete(T entity)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public virtual void Update(T entity)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public T Get(Expression<Func<T, bool>> filter)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }
        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                return filter == null ?
                    context.Set<T>().ToList() :
                    context.Set<T>().Where(filter).ToList();
            }
        }
        public bool CheckIfRealPerson(IPerson person)
        {
            throw new NotImplementedException();
        }
    }
}
