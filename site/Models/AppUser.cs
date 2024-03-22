

using Microsoft.AspNetCore.Identity;

namespace site.Models
{
    public class AppUser
    {
        public int? Milage { get; set; }
        public int? Pace { get; set; }
        public Adress? Adress { get; set; }

        public ICollection<Club> Clubs { get; set; }

        public ICollection<Race> Race { get; set; }

    }
}
