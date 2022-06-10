using Microsoft.EntityFrameworkCore;

namespace Diplom.Persistence
{
    /// <summary>
    /// Сидинг для БД.
    /// </summary>
    public interface ISeedingService
    {
        /// <summary>
        /// Заполнить БД.
        /// </summary>
        /// <param name="modelBuilder"></param>
        void Initialized(ModelBuilder modelBuilder);
    }
}
