using System.ComponentModel.DataAnnotations;

namespace Ads.Data.Entity
{
	public class Category
	{
		[Key]
		public int? Id { get; set; }

		[MaxLength(100)]
		public string? Name { get; set; }
		[MaxLength(200)]
		public string? Description { get; set; }
	}
}
