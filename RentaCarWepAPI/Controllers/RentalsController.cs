using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentaCarBusiness.Abstract;
using RentaCarBusiness.BusinessAspect.Autofac;
using RentaCarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCarWepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _rentalService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("GetAllCustomerId")]
        public IActionResult GetAllCustomerId(int customerId)
        {
            var result = _rentalService.GetAllCustomerId(customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("RentableCar")]
        public IActionResult RentableCar(int carId)
        {
            var result = _rentalService.RentableCar(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("GetNotRentableCarDetails")]
        public IActionResult GetNotRentableCarDetails()
        {
            var result = _rentalService.GetNotRentableCarDetails();
            if (result.Success)
            {
                return Ok(result);            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("Add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("Delete")]
        public IActionResult Delete(int id)
        {
            var result = _rentalService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("Update")]
        public IActionResult Update(int id)
        {
            var result = _rentalService.Update(id);
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
