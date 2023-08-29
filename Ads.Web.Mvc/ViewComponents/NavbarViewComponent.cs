using Ads.Data; // Gerekli using bildirimleri burada olmalı
using Ads.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

public class NavbarViewComponent : ViewComponent
{
	private readonly AppDbContext _dbContext;

	public NavbarViewComponent(AppDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public IViewComponentResult Invoke()
	{
		var categories = _dbContext.Categories.ToList(); // Veritabanından kategorileri çekin

		var pages = _dbContext.Pages.ToList(); // Veritabanından sayfaları çekin

		var viewModel = new NavbarViewModel
		{
			Categories = categories,
			Pages = pages
		};

		return View(viewModel);
	}
}
