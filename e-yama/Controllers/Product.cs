using Microsoft.AspNetCore.Mvc;

namespace e_yama.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}