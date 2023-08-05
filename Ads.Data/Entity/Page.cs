using System.ComponentModel.DataAnnotations;

namespace Ads.Data.Entity
{
	public class Page
	{
		[Key]
		public int? Id { get; set; }
		[MaxLength(200)]
		public string? Title { get; set; }
		public string? Content { get; set; }
		public bool? IsActive { get; set; }
	}
}
