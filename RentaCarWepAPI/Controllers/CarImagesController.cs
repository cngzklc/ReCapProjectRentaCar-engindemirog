using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentaCarBusiness.Abstract;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCarWepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpPost("Add")]
        public IActionResult Add([FromForm] CarImage carImage, [FromForm(Name = ("image"))] IFormFile file)
        {
            var result = _carImageService.Add(carImage, file);
            if (!result.Success)
            {
                return BadRequest(result);                
            }
            return Ok(result);

        }
        [HttpPost("Delete")]
        public IActionResult Delete([FromForm(Name = ("image"))] int carImageId)
        {
            var result = _carImageService.Delete(carImageId);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("Update")]
        public IActionResult Update([FromForm(Name = ("image"))] int carImageId)
        {
            var result = _carImageService.Update(carImageId);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpGet("GetById")]
        public IActionResult GetById([FromForm(Name = ("CarImageId"))] int carImageId)
        {
            var result = _carImageService.GetById(carImageId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("GetCarImages")]
        public IActionResult GetCarImages([FromForm(Name = ("CarId"))] int carId)
        {
            var result = _carImageService.GetCarImages(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
