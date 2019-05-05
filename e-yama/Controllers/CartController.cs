using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_yama.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}