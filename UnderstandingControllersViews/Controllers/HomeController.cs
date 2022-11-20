using Microsoft.AspNetCore.Mvc;
using UnderstandingControllersViews.Models;

namespace UnderstandingControllersViews.Controllers
{
    public class HomeController : Controller
    {
        private IWebHostEnvironment hostingEnvironment;
        public HomeController(IWebHostEnvironment environment)
        {
            hostingEnvironment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormFile photo)
        {
            // code to save the uploaded file in wwwroot folder
            using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, photo.FileName), FileMode.Create))
            {
                 await photo.CopyToAsync(stream);
            }

            return View();
        }

        public IActionResult ReceivedDataByRequest()
        {
            string name = Request.Form["name"];
            string sex = Request.Form["sex"];
            return View("ReceivedDataByRequest", $"{name} sex is {sex}");
        }

        public IActionResult ReceivedDataByParameter(string name, string sex)
        {
            return View("ReceivedDataByParameter", $"{name} sex is {sex}");
        }

        public IActionResult ReceivedDataByModelBinding(Person person)
        {
            return View("ReceivedDataByModelBinding", person);
        }

        public IActionResult CallSharedView()
        {
            return View();
        }

        public IActionResult TestLayout()
        {
            ViewBag.Title = "Welcome to TestLayout";
            return View();
        }

        public IActionResult Joke()
        {
            return View();
        }
    }
}