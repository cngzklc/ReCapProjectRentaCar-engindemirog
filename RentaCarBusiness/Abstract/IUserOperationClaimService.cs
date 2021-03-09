using Core.Utilities.Results.Abstract;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace RentaCarBusiness.Abstract
{
    public interface IUserOperationClaimService
    {
        IDataResult<List<UserOperationClaim>> GetAll();
        IResult Add(UserOperationClaim sserOperationClaim);
        IDataResult<UserOperationClaim> GetById(int id);
        IResult Delete(int id);
        IResult Update(int id);
    }
}
