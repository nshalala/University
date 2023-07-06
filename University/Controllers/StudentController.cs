using Microsoft.AspNetCore.Mvc;
using University.ViewModels;

namespace University.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentViewModel vm = new StudentViewModel()
            {
                Students = Data.Students,
                Groups = Data.Groups,
            };
            return View(vm);
        }
        public IActionResult Detail(int id)
        {
            var std = Data.Students.Find(std => std.Id == id);
            
            if(std == null) View("Error");

            StudentDetailViewModel vm = new StudentDetailViewModel()
            {
                Std = std,
                Groups = Data.Groups,
            };

            return View(vm);
        }
    }
}
