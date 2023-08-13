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
			    // Add more Page entries as needed
		    };

            dbContext.Pages.AddRange(pages);
            dbContext.SaveChanges();
        }
    }


}