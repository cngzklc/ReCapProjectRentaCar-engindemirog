using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarEntities.Concrete
{
    public class User : IPerson
    {
        string _lastName;
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get { return _lastName; } set { _lastName = value.ToUpper(); } }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
