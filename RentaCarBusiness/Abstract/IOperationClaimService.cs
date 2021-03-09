using Core.Utilities.Results.Abstract;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace RentaCarBusiness.Abstract
{
    public interface IOperationClaimService
    {
        IDataResult<List<OperationClaim>> GetAll();
        IResult Add(OperationClaim operationClaim);
        IDataResult<OperationClaim> GetById(int id);
        IResult Delete(int id);
        IResult Update(int id);
    }
}
