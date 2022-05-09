using Ardalis.Specification;
using Diplom.Domain.Entities;

namespace Diplom.Infrastructure.Specifications.UserSpecifications
{
    public class GetUserSpec : Specification<User>, ISingleResultSpecification
    {
        public GetUserSpec(string userName)
        {
            Query.Where(u => u.UserName == userName);
        }
    }
}
