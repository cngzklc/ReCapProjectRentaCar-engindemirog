using Core.Aspects.Autofac.Validation;
using Core.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Http;
using RentaCarBusiness.Abstract;
using RentaCarBusiness.ValidationRules.FluentValidation;
using RentaCarDataAccess.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if(!result.Success)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Add(formFile);
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

        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<List<CarImage>> GetImagesByCarId(int id)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfAnyCarImageExists(id));
        }
        IResult CheckIfMaxQty(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            if (result.Count >= 5)
            {
                return new ErrorResult(Messages.NoMoreCarImagesCanBeAdded);
            }
            return new SuccessResult();
        }
        private List<CarImage> CheckIfAnyCarImageExists(int carId)
        {
            string path = Environment.CurrentDirectory + @"\ImagesFolder\CarImagesFolder\CK Logo.png";
            var result = _carImageDal.GetAll(c => c.CarId == carId).Any();

            if (result)
            {
                return _carImageDal.GetAll(p => p.CarId == carId);
            }

            return new List<CarImage> { new CarImage { CarId = carId, ImagePath = path, Date = DateTime.Now } };
        }
    }
}
