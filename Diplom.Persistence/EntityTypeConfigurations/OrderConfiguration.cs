using Diplom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diplom.Persistence.EntityTypeConfigurations;

/// <summary>
/// Конфигурация заказа.
/// </summary>
internal class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.Id).IsUnique();
        builder.Property(e => e.CreateDate).IsRequired();

        builder.HasOne(e => e.User).WithMany(u => u.Orders).IsRequired();
        builder.HasMany(e => e.Sales).WithOne(u => u.Order).IsRequired();
    }
}
