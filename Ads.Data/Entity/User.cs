using System.ComponentModel.DataAnnotations;

namespace Ads.Data.Entity
{
	public class User
	{
		[Key]
		public int? Id { get; set; }
		[MaxLength(200)]
		public string? Email { get; set; }
		[MaxLength(100)]
		public string? Password { get; set; }
		[MaxLength(100)]
		public string? Name { get; set; }
		[MaxLength(200)]
		public string? Address { get; set; }
		[MaxLength(20)]
		public string? Phone { get; set; }
	}
}
