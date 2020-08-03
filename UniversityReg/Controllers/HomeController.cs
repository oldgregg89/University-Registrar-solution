using Microsoft.AspNetCore.Mvc;

namespace UniversityReg.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}