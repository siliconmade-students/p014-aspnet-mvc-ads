using System.ComponentModel.DataAnnotations;

namespace Ads.Data.Entity
{
	public class AdvertComment
	{
		[Key]
		public int? Id { get; set; }
		[Required]
		public int? AdvertId { get; set; }
		[Required]
		public int? UserId { get; set; }
		public string? Comment { get; set; }
		[Required]
		public bool? IsActive { get; set; }
	}
}
