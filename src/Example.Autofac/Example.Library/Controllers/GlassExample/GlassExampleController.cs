using Example.Library.Models.GlassModels;
using Example.Library.Services;
using System.Web.Mvc;
using Glass.Mapper.Sc;

namespace Example.Library.Controllers.InjectionExample
{
    public class GlassExampleController : Controller
    {
        private ISitecoreContext _context;

        public GlassExampleController(ISitecoreContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var item = _context.GetCurrentItem<Page>();

            return View("~/Views/GlassExample/Index.cshtml", item);
        }
    }
}
