using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentaCarDataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal_Alternatif
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand { BrandId=1, BrandName="Audi"},
                new Brand { BrandId=2, BrandName="BMW"},
                new Brand { BrandId=3, BrandName="Ford"},
                new Brand { BrandId=4, BrandName="Mercedes"},
                new Brand { BrandId=5, BrandName="Fiat"},
                new Brand { BrandId=6, BrandName="Renault"},
                new Brand { BrandId=7, BrandName="Volkswagen"},
                new Brand { BrandId=8, BrandName="Skoda"},
                new Brand { BrandId=9, BrandName="Peugeot"}
            };
        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            _brands.Remove(brandToDelete);
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
