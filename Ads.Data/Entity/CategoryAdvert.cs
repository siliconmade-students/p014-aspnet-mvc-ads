using System.ComponentModel.DataAnnotations;

namespace Ads.Data.Entity
{
	public class CategoryAdvert
	{
		[Key]
		public int? Id { get; set; }
		[Required]
		public int? CategoryId { get; set; }
		[Required]
		public int? AdvertId { get; set; }
	}
}
