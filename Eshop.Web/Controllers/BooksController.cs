using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EShop.Repository;
using Eshop.Domain.Domain;
using EShop.Domain;

namespace Eshop.Web.Controllers
{
    using Eshop.Domain.Domain;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using NuGet.Versioning;

    namespace EShop.Controllers
    {
        public class BooksController : Controller
        {
            private readonly ApplicationDbContext _context;

            public BooksController(ApplicationDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                var books = _context.Book.Include(b => b.Publisher).Include(b => b.Authors).ToList();
                return View(books);
            }

            public IActionResult Create()
            {
                ViewBag.Authors = _context.Authors.ToList();
                ViewBag.Publishers = _context.Publishers.ToList();
                return View();
            }

            [HttpPost]
            public IActionResult Create(Book book, Guid authorId, Guid publisherId)
            {
                var author = _context.Authors.Find(authorId);
                var publisher = _context.Publishers.Find(publisherId);

                if (author != null && publisher != null)
                {
                    book.Authors = new List<Author> { author };
                    book.Publisher = publisher;

                    _context.Book.Add(book);
                    _context.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }

            [HttpPost]
            public async Task<IActionResult> AddToOrder(Guid bookId, int quantity = 1)
            {
                // Fetch the book to ensure it exists
                var book = await _context.Book.FindAsync(bookId);
                if (book == null)
                {
                    return NotFound("Book not found.");
                }

                // Fetch the active order or create a new one
                var order = await _context.Orders
                    .Include(o => o.BookInOrders)
                    .FirstOrDefaultAsync();

                if (order == null)
                {
                    order = new Order
                    {
                        Id = Guid.NewGuid(),
                        BookInOrders = new List<BookInOrder>()
                    };
                    _context.Orders.Add(order);
                }

                // Check if the book is already in the order
                var bookInOrder = order.BookInOrders.FirstOrDefault(bio => bio.Book.Id == bookId);
                if (bookInOrder != null)
                {
                    // Update the quantity if the book already exists in the order
                    bookInOrder.Quantity += quantity;
                }
                else
                {
                    // Add a new BookInOrder
                    bookInOrder = new BookInOrder
                    {
                        Id = Guid.NewGuid(),
                        Book = book,
                        Order = order,
                        Quantity = quantity
                    };
                    order.BookInOrders.Add(bookInOrder);
                }

                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Orders");
            }
        
        }
    }

}
