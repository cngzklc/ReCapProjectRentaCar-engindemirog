using Core.Aspects.Autofac.Validation;
using Core.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using RentaCarBusiness.Abstract;
using RentaCarBusiness.ValidationRules.FluentValidation;
using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }
        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == colorId));
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.Added(color));
        }

        public IResult Delete(int id)
        {
            Color color = _colorDal.Get(c => c.ColorId == id);
            _colorDal.Delete(color);
            return new SuccessResult(Messages.Added(color));
        }

        public IResult Update(int id)
        {
            Color color = _colorDal.Get(c => c.ColorId == id);
            _colorDal.Update(color);
            return new SuccessResult(Messages.Added(color));
        }
    }
}
