using System.Configuration;
using System.Web.Mvc;
using SpankedPuppy.Web.Models;

namespace SpankedPuppy.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET
        public ActionResult Index()
        {
            var model = new GreetingViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}