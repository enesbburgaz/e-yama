using Microsoft.AspNetCore.Mvc;

namespace e_yama.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index(){
            ViewBag.final = "Final sorusudur";
            return View();
        }
    }
}