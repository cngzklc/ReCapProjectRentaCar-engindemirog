using Microsoft.EntityFrameworkCore;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCapProjectRentaCar; Trusted_Connection=true");
        }

        public DbSet<Car> Cars;
        public DbSet<Color> Colors;
        public DbSet<Brand> Brands;
    }
}
