using Core.DataAccess.Abstract;
using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RentaCarDataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IEntityRepository<Brand>
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand { Id=1, BrandName="Audi"},
                new Brand { Id=2, BrandName="BMW"},
                new Brand { Id=3, BrandName="Ford"},
                new Brand { Id=4, BrandName="Mercedes"},
                new Brand { Id=5, BrandName="Fiat"},
                new Brand { Id=6, BrandName="Renault"},
                new Brand { Id=7, BrandName="Volkswagen"},
                new Brand { Id=8, BrandName="Skoda"},
                new Brand { Id=9, BrandName="Peugeot"}
            };
        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.Id == brand.Id);
            _brands.Remove(brandToDelete);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            var query = filter.Compile();
            return (Brand)_brands.SingleOrDefault(query.Invoke);
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            if (filter == null)
            {
                return _brands;
            }
            else
            {
                var query = filter.Compile();
                return _brands.Where(query.Invoke).ToList();
            }
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.Id == brand.Id);
            brandToUpdate.BrandName = brand.BrandName;
        }
    }
}
