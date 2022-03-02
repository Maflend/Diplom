using Diplom.Domain.Entities;
using Diplom.Domain.Entities.Phone;
using Microsoft.EntityFrameworkCore;

namespace Diplom.Application.Interfaces
{
    public interface IDiplomContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Sale> Sales { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Phone> Phones { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
