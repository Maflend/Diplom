using Ardalis.Specification;
using Diplom.Domain.Entities;

namespace Diplom.Infrastructure.Specifications.UserSpecifications
{
    public class GetUserByUserNameSpec : Specification<User>, ISingleResultSpecification
    {
        public GetUserByUserNameSpec(string userName)
        {
            Query.Where(u => u.UserName == userName);
        }
    }
}
