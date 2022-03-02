using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.Domain.Entities;
using Diplom.Application.Interfaces;
using Diplom.Persistence.EntityTypeConfigurations;
using Diplom.Domain.Entities.Phone;
using Diplom.Domain.Entities.Phone.Characteristics;

namespace Diplom.Persistence.Contexts
{
    public class DiplomContext :  DbContext, IDiplomContext
    {
        public DiplomContext(DbContextOptions<DiplomContext> options) : base(options)  { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new PhoneConfiguration());

            modelBuilder.Entity<Category>().HasData(InitialData.Categories);
            modelBuilder.Entity<FactoryData>().HasData(InitialData.Factory);
            modelBuilder.Entity<Phone>().HasData(InitialData.Phone);



        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

    }
}
