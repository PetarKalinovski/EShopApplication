using EShop.Domain.Domain;

namespace Eshop.Domain.Domain
{
    public class BookInOrder : BaseEntity
    {
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Book Book { get; set; }
    }

}
