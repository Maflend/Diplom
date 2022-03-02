using Diplom.Domain.Entities.Phone;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Persistence.EntityTypeConfigurations
{
    public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.ToTable("Phones");
            builder.HasOne(e => e.FactoryData).WithOne(e=>e.Phone);
            //builder.OwnsOne(e => e.GeneralParameters);
            //builder.OwnsOne(e => e.Appearance);
            //builder.OwnsOne(e => e.Display);
            //builder.OwnsOne(e => e.MobileCommunications);
           
            //builder.OwnsOne(e => e.System);
        }
    }
}
