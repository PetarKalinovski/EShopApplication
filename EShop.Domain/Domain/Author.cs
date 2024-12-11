using EShop.Domain.Domain;

namespace Eshop.Domain.Domain
{
    public class Author : BaseEntity
    {
        public string? name { get; set; }
        public string? biography { get; set; }

        public ICollection<Book>? books { get; set; }
    }
}
