using Microsoft.AspNetCore.Mvc;

//* Creo un Controller 1)

namespace FindYourCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(){
            return Content("sono index");
        }

        public IActionResult Details(string id){
            return Content($"sono detail {id}");
        }
    }
}