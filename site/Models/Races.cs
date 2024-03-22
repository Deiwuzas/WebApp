using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using site.Data.Enum;

namespace site.Models
{
    public class Race
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }
        [ForeignKey("Adress")]
        public int AddressId { get; set; }
        public Adress Adress { get; set; }
        public RaceCategory RaceCategory { get; set; }
        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
