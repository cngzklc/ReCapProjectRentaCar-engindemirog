﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.DTOs
{
    public class UserForRegisterDto : IDto // Kullanıcı kayıt tarafı
    {
        public string  Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalId { get; set; }
    }
}
