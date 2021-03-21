using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
namespace CompanyApplication
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}