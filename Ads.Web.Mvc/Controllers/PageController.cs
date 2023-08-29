using Ads.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ads.Web.Mvc.Controllers
{
	public class PageController : Controller
	{
		private readonly AppDbContext _dbContext;

		public PageController(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Detail(int id)
		{
			var page = _dbContext.Pages.FirstOrDefault(p => p.Id == id);
			if (page == null)
			{
				return NotFound();
			}

			return View(page);
		}
	}
}

