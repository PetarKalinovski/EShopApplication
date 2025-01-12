using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Eshop.Domain.Domain;
using EShop.Repository;

namespace Eshop.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var bookInOrders = await _context.BookInOrders
                .Include(b => b.Book)
                .Include(b => b.Order)
                .ToListAsync();

            return View(bookInOrders);
        }
    }
}
