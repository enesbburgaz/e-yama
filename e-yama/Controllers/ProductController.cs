using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_yama.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}