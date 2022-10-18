using System.ComponentModel;

namespace Diplom.Client.Infrastructure.Models.Enums;

/// <summary>
/// Енам ролей пользователя.
/// </summary>
public enum RoleEnum
{
    /// <summary>
    /// Администратор.
    /// </summary>
    [Description("Администратор")]
    Administrator = 0,

    /// <summary>
    /// Клиент.
    /// </summary>
    [Description("Клиент")]
    Client = 1
}
