using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreateDate { get; set; }
        public Guid UserId { get; set; }
        public Guid SaleId { get; set; }
        public List<Sale> Sales { get; set; }
        public User User { get; set; }

    }
}
