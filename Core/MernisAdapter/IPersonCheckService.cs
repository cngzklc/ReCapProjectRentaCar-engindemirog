using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.MernisAdapter
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(IPerson person);
    }
}
