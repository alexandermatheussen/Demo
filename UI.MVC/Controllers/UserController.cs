using Microsoft.AspNetCore.Mvc;

namespace D.UI.MVC.Controllers
{
    public class UserController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}