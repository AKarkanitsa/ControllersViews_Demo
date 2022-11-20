using Microsoft.AspNetCore.Mvc;
using UnderstandingControllersViews.Models;

namespace UnderstandingControllersViews.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewBagExample()
        {
            ViewBag.CurrentDateTime = DateTime.Now;
            ViewBag.CurrentYear = DateTime.Now.Year;
            return View();
        }

        public IActionResult TempDataExample()
        {
            TempData["CurrentDateTime"] = DateTime.Now;
            TempData["CurrentYear"] = DateTime.Now.Year;
            return RedirectToAction("TempDataShow");
        }

        public IActionResult TempDataShow()
        {
            return View();
        }

        public IActionResult SessionExample()
        {
            HttpContext.Session.SetString("CurrentDateTime", DateTime.Now.ToString());
            HttpContext.Session.SetInt32("CurrentYear", DateTime.Now.Year);
            
            Employee p = new Employee() { Name = "Alex", Address = "Belarus" };
            HttpContext.Session.Set<Employee>("MyEmployeeClass", p);

           // public RedirectResult RedirectAction() => Redirect("/List/Search");



            return View();
        }

        //public RedirectToRouteResult Redirect()
        //{
        //    RedirectToRoute(new { controller = "Admin", action = "Users", ID = "10" });
        //}

        public JsonResult ReturnJson()
        {
            return Json(new[] { "Jon", "Bob", "Alisa" });
        }

        public OkObjectResult ReturnOk()
        {
            return Ok(new string[] { "Jon", "Bob", "Alisa" });
        }

        public StatusCodeResult ReturnBadRequst()
        {
            return StatusCode(StatusCodes.Status400BadRequest);
        }

        public StatusCodeResult ReturnUnauthorized()
        {
            return StatusCode(StatusCodes.Status401Unauthorized);
        }

        public StatusCodeResult ReturnNotFound()
        {
            return StatusCode(StatusCodes.Status404NotFound);
            //or return NotFound();
        }

        public IActionResult CallSharedView()
        {
            return View();
        }
    }
}
