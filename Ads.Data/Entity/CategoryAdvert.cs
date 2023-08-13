using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ads.Data.Entity
{
    public class CategoryAdvert
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int AdvertId { get; set; }

        public Advert Advert { get; set; }
    }
}
