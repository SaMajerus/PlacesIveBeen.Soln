using Microsoft.AspNetCore.Mvc;

namespace PlacesBeen.Controllers
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