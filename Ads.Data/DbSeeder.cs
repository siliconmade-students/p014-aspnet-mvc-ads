using Ads.Data;
using Ads.Data.Entity;


public class DbSeeder
{
	public static void Seed(AppDbContext dbContext)
	{
		// Check if Pages already exist in the database
		if (!dbContext.Pages.Any())
		{
			var pages = new Page[]
			{
				new Page
				{

					Title = "About Us",
					Content = "Welcome to our About Us page...",
					IsActive = true
				},
				new Page
				{

					Title = "Contact Us",
					Content = "Feel free to contact us anytime...",
					IsActive = true
				},


			};

			dbContext.Pages.AddRange(pages);
			dbContext.SaveChanges();
		}

		if (!dbContext.Categories.Any())
		{
			var categories = new Category[]
			{
				new Category
				{
					Name = "Category1",
					Description = "DENemeler1"
				},
				new Category
				{
					Name = "Category2",
					Description = "DENemeler2"
				}
			};

			dbContext.Categories.AddRange(categories);
			dbContext.SaveChanges();

		};




	}
	// Add more Page entries as needed
}


