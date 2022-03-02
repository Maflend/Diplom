using Diplom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Persistence.EntityTypeConfigurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.Property(e => e.Quantity).IsRequired();
            builder.Property(e => e.ProductId).IsRequired();
            builder.Property(e => e.OrderId).IsRequired();

            builder.HasOne(e => e.Product).WithMany(p=>p.Sales).HasForeignKey(e=>e.ProductId);
            builder.HasOne(e => e.Order).WithMany(o => o.Sales).HasForeignKey(e=>e.OrderId);
        }
    }
}
