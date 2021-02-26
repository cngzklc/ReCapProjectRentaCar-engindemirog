using Core.Aspects.Autofac.Validation;
using Core.Constants;
using Core.Utilities.Business;
using Core.Utilities.FileOperations;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Http;
using RentaCarBusiness.Abstract;
using RentaCarBusiness.ValidationRules.FluentValidation;
using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage carImage, IFormFile formFile)
        {
            IResult result = BusinessRules.Run(CheckIfMaxQty(carImage.CarId));
            if(result != null)
            {
                return result;
            }
            carImage.ImagePath = WepApiFileManager.AddAsync(formFile);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.Added(carImage));
        }

        public IResult Delete(int id)
        {
            CarImage carImage = _carImageDal.Get(c => c.CarImageId == id);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.Added(carImage));
        }

        public IResult Update(int id)
        {
            CarImage carImage = _carImageDal.Get(c => c.CarImageId == id);
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Added(carImage));
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int carImageId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.CarImageId == carImageId));
        }

        public IDataResult<List<CarImage>> GetCarImages(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
        }
        IResult CheckIfMaxQty(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            if (result.Count > 5)
            {
                return new ErrorResult(Messages.NoMoreCarImagesCanBeAdded);
            }
            return new SuccessResult();
        }
    }
}
