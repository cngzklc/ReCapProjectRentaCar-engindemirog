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
                new Color() { ColorId=1 , ColorName="Siyah" },
                new Color() { ColorId=2 , ColorName="Beyaz" },
                new Color() { ColorId=3 , ColorName="Kırmızı" },
                new Color() { ColorId=4 , ColorName="Mavi" },
                new Color() { ColorId=5 , ColorName="Gri" },
                new Color() { ColorId=6 , ColorName="Yeşil" },
                new Color() { ColorId=7 , ColorName="Bordo" },
                new Color() { ColorId=8 , ColorName="Füme" },
                new Color() { ColorId=9 , ColorName="Lacivert" },
            };
        }
        public void Add(Color entity)
        {
            _colors.Add(entity);
        }

        public void Delete(Color entity)
        {
            Color ColorToDelete = _colors.SingleOrDefault(c => c.ColorId == entity.ColorId);
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
            Color ColorToUpdated = _colors.SingleOrDefault(c => c.ColorId == entity.ColorId);
            ColorToUpdated.ColorName = entity.ColorName;
            ColorToUpdated.ColorId = entity.ColorId;
        }
    }
}
