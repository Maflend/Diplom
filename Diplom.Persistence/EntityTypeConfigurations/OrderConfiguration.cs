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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.Property(e => e.CreateDate).IsRequired();
            builder.Property(e => e.SaleId).IsRequired();
            builder.Property(e => e.UserId).IsRequired();

            builder.HasOne(e => e.User).WithMany(u => u.Orders).IsRequired();
            builder.HasMany(e => e.Sales).WithOne(u => u.Order).IsRequired();
        }
    }
}
