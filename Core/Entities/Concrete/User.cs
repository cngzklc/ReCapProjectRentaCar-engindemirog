using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class User : IPerson
    {
        string _lastName;
        public int Id { get; set; }
        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get { return _lastName; } set { _lastName = value.ToUpper(); } }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
    }
}
