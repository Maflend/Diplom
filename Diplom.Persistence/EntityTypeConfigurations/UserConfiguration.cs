using Diplom.Domain.Entities;
using Diplom.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diplom.Persistence.EntityTypeConfigurations;

/// <summary>
/// Конфигурация юзера.
/// </summary>
internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.Id).IsUnique();
        builder.Property(e => e.UserName).IsRequired();
        builder.Property(e => e.Age).IsRequired();

        builder.Property(e => e.Role).HasColumnType("varchar").HasConversion(
            v => v.ToString(),
            v => (RoleEnum)Enum.Parse(typeof(RoleEnum), v)).IsRequired();

        builder.Property(e => e.PasswordHash).IsRequired();
        builder.Property(e => e.PasswordSalt).IsRequired();

        builder.HasMany(e => e.Orders).WithOne(o => o.User);
    }
}
