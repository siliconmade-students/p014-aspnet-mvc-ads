using Ads.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ads.Data
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Advert> Adverts { get; set; }
		public DbSet<CategoryAdvert> CategoryAdverts { get; set; }
		public DbSet<AdvertImage> AdvertImages { get; set; }
		public DbSet<AdvertComment> AdvertComments { get; set; }
		public DbSet<Page> Pages { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Setting> Settings { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Örnek: modelBuilder.Entity<Category>().HasMany(c => c.Adverts).WithOne(a => a.Category);
			// ...
			DbSeeder.Seed(modelBuilder);
			base.OnModelCreating(modelBuilder);

		}
	}
}
