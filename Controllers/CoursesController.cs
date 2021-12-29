using Microsoft.AspNetCore.Mvc;

//* Creo un Controller 1)

namespace FindYourCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        public IActionResult Details(string id){
            ViewBag.numero = id;
            return View();
        }
    }
}