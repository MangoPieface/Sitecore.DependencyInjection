using Example.Library.Models;
using Example.Library.Services;
using System.Web.Mvc;

namespace Example.Website.Controllers
{
    public class SitecoreExampleController : Controller
    {
        private readonly IExampleService _exampleService;

        public SitecoreExampleController(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        // GET: Sitecore
        public ActionResult Index()
        {
            _exampleService.GetPage();
            return View(new PageModel() { Title = "Hello from the controller" });
        }
    }
}