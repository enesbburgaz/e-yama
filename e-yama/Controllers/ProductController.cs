using System.Linq;
using System.Threading.Tasks;
using e_yama.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_yama.Controllers
{
    public class ProductController : Controller
    {
        private readonly EfDataContext _context;
        public ProductController(EfDataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int id){
            return View(await _context.Products.FindAsync(id));
        }
    }
}