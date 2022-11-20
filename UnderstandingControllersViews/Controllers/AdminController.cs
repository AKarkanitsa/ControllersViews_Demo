using Microsoft.AspNetCore.Mvc;

namespace UnderstandingControllersViews.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
