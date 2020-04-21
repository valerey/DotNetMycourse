using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return Content("Sono INdex");
        }

        public IActionResult Detail(string id)
        {
            return Content($"Sono Detail, ho ricevuto id {id}");
        }
    }
}