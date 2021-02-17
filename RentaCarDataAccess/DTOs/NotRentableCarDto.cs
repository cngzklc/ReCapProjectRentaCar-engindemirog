using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.DTOs
{
    public class NotRentableCarDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string CarName { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
