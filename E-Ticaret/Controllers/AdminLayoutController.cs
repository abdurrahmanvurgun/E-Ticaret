using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
