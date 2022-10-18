using Ardalis.Specification;
using Diplom.Domain.Entities;

namespace Diplom.Domain.Specifications.UserSpecifications;

/// <summary>
/// Спецификация пользователя.
/// </summary>
public class GetUserSpec : Specification<User>, ISingleResultSpecification
{
    /// <summary>
    /// Получить пользователя по userName.
    /// </summary>
    /// <param name="userName">Имя пользователя.</param>
    public GetUserSpec(string userName)
    {
        Query.Where(u => u.UserName == userName);
    }
}
