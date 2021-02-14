using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public interface IPerson:IEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string NationalId { get; set; }
        DateTime DateOfBirth { get; set; }

    }
}
