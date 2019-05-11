using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using e_yama.Models;
using Microsoft.AspNetCore.Authorization;
using e_yama.Data;
using Microsoft.EntityFrameworkCore;

namespace e_yama.Controllers
{
    public class HomeController : Controller
    {
        private readonly EfDataContext _context;
        public HomeController(EfDataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        public IActionResult Cimento()
        {
            //var item = await _context.Products.Where(x => x.Category.Id == 1).ToListAsync();
            return RedirectToAction("Store");
        }
        public IActionResult Store()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
