using Microsoft.AspNetCore.Mvc;

namespace Ads.Web.Mvc.Areas.Admin.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
