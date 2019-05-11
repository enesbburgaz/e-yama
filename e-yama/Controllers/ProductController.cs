using Microsoft.AspNetCore.Mvc;

namespace e_yama.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}