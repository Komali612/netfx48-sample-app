using System.Web.Mvc;

namespace Netfx48SampleApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from the .NET Framework 4.8 sample app.";
            return View();
        }
    }
}
