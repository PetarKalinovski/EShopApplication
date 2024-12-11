using EShop.Domain.Domain;

namespace Eshop.Domain.Domain
{
    public class Order : BaseEntity
    {
        public string userId {  get; set; }
        public Guid Id { get; set; }
        public ICollection<BookInOrder> books { get; set; }
    }
}
