using Core.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Http;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarBusiness.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetCarImages(int carId);
        IDataResult<CarImage> GetById(int carImage);
        IResult Add(CarImage carImage, IFormFile formFile);
        IResult Delete(int id);
        IResult Update(int id);
    }
}
