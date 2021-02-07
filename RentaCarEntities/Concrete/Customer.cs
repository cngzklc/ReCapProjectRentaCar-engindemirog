﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarEntities.Concrete
{
    public class Customer: IEntity
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
    }
}
