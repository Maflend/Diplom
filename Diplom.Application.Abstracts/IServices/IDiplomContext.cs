using Diplom.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Diplom.Application.Abstracts.IServices
{
    public interface IDiplomContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Sale> Sales { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
