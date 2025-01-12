using Eshop.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain
{
    public class BooksIndexViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public Guid OrderId { get; set; }
    }

}
