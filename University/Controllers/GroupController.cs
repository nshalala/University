using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.Groups);
        }
    }
}
