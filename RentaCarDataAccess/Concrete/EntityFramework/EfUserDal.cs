using Core.DataAccess.EntityFramework;
using Core.Entities;
using Core.MernisAdapter;
using RentaCarDataAccess.Abstract;
using Core.Entities.Concrete;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RentaCarDataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentaCarContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user) // Bu method kullanıcıların sahip olduğu yetkileriçekmek için kullanılıyor.
        {
            using (var context = new RentaCarContext())
            {
                var result = from oc in context.OperationClaims
                             join uoc in context.UserOperationClaims
                             on oc.Id equals uoc.OperationClaimId
                             where uoc.UserId == user.Id
                             select new OperationClaim { Id = oc.Id, Name = oc.Name };
                return result.ToList();
            }
        }
    }
}
