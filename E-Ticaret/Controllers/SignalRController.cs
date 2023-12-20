using Microsoft.AspNetCore.Mvc;

namespace E_TicaretUI.Controllers
{
    public class SignalRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
