using EShop.Domain.Domain;

namespace Eshop.Domain.Domain
{
    public class Order : BaseEntity
    {
        public ICollection<BookInOrder> BookInOrders { get; set; } = new List<BookInOrder>();
    }
}

