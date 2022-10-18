using Diplom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diplom.Persistence.EntityTypeConfigurations;

/// <summary>
/// Конфигурация продукта
/// </summary>
internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(u => u.Id);
        builder.HasIndex(u => u.Id).IsUnique();
        builder.Property(u => u.Name).IsRequired();
        builder.Property(u => u.ImgUrl).IsRequired();
        builder.Property(u => u.Price).IsRequired();
        builder.Property(u => u.PurchasePrice).IsRequired();

        builder.HasOne(p => p.Category).WithMany(c => c.Products).IsRequired();
    }
}
