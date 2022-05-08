namespace Diplom.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreateDate { get; set; }
        public List<Sale> Sales { get; set; }
        public User User { get; set; }

    }
}
