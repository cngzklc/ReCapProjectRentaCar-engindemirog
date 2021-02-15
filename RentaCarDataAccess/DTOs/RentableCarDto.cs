using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.DTOs
{
    public class RentableCarDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string CarName { get; set; }
        public string Description { get; set; }
    }
}
