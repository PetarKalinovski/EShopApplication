using EShop.Domain.Domain;

namespace Eshop.Domain.Domain
{
    public class BookInOrder : BaseEntity
    {
        public Book Book { get; set; }

        public Guid orderId { get; set; }

        public Order Order { get; set; }

        public int Quantity { get; set; }
    }
}
