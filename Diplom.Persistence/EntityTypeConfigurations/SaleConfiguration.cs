using Diplom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diplom.Persistence.EntityTypeConfigurations
{
    /// <summary>
    /// Конфигурация продажи.
    /// </summary>
    internal class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.Property(e => e.Quantity).IsRequired();


            builder.HasOne(e => e.Product);
            builder.HasOne(e => e.Order).WithMany(o => o.Sales);
        }
    }
}
