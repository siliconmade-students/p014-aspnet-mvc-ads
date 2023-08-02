using System.ComponentModel.DataAnnotations;

namespace Ads.Data.Entity
{
	public class Setting
	{
		[Key]
		public int? Id { get; set; }
		[Required]
		public int? UserId { get; set; }
		[MaxLength(200)]
		public string? Name { get; set; }
		[MaxLength(400)]
		public string? Value { get; set; }
	}
}
