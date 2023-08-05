using System.ComponentModel.DataAnnotations;

namespace Ads.Data.Entity
{
	public class AdvertImage
	{
		[Key]
		public int? Id { get; set; }
		public int? AdvertId { get; set; }
		[MaxLength(200)]
		public string? ImagePath { get; set; }
	}
}
