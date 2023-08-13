using System.ComponentModel.DataAnnotations;

namespace Ads.Data.Entity
{
    public class Advert
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public int? UserId { get; set; }
        [MaxLength(200)]
        public string? Title { get; set; }
        public string? Description { get; set; }

        //public List<Category> Categories { get; set; }

        public List<CategoryAdvert> CategoryAdverts { get; set; }
    }
}
