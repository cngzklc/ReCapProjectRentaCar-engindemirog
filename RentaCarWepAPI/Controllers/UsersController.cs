using Core.MernisAdapter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentaCarBusiness.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCarWepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
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
            var result = _userService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("Add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        //[HttpPost("Delete")]
        //public IActionResult Delete(int id)
        //{
        //    var result = _userService.Delete(id);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    else
        //    {
        //        return BadRequest(result);
        //    }
        //}
        //[HttpPost("Update")]
        //public IActionResult Update(int id)
        //{
        //    var result = _userService.Update(id);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    else
        //    {
        //        return BadRequest(result);
        //    }
        //}
    }
}
