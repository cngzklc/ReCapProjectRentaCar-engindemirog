using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RentaCarDataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>()
            {
                new Color() { Id=1 , ColorName="Siyah" },
                new Color() { Id=2 , ColorName="Beyaz" },
                new Color() { Id=3 , ColorName="Kırmızı" },
                new Color() { Id=4 , ColorName="Mavi" },
                new Color() { Id=5 , ColorName="Gri" },
                new Color() { Id=6 , ColorName="Yeşil" },
                new Color() { Id=7 , ColorName="Bordo" },
                new Color() { Id=8 , ColorName="Füme" },
                new Color() { Id=9 , ColorName="Lacivert" },
            };
        }
        public void Add(Color entity)
        {
            _colors.Add(entity);
        }

        public void Delete(Color entity)
        {
            Color ColorToDelete = _colors.SingleOrDefault(c => c.Id == entity.Id);
            _colors.Remove(ColorToDelete);
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            var query = filter.Compile();
            return (Color)_colors.SingleOrDefault(query.Invoke);
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            if (filter == null)
            {
                return _colors;
            }
            else
            {
                var query = filter.Compile();
                return _colors.Where(query.Invoke).ToList();
            }
        }

        public void Update(Color entity)
        {
            Color ColorToUpdated = _colors.SingleOrDefault(c => c.Id == entity.Id);
            ColorToUpdated.ColorName = entity.ColorName;
            ColorToUpdated.Id = entity.Id;
        }
    }
}
