using EShop.Domain.Domain;

namespace Eshop.Domain.Domain
{
    public class Book : BaseEntity
    {
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? date { get; set; }

        public float? price { get; set; }

        public ICollection<Author>? authors { get; set; }

        public Publisher? publisher { get; set; }
    }
}
