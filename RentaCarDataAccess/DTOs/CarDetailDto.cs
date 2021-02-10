using System;
using System.Collections.Generic;
using Core.Entities;
using System.Text;

namespace RentaCarDataAccess.DTOs
{
    public class CarDetailDto : IDto
    {
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
