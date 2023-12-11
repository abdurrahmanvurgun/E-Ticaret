using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.ViewComponents.LayoutComponents
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
