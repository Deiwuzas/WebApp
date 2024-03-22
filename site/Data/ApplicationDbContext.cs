using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using site.Models;

namespace site.Data
{
    public class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //
        }
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Adress> Adresses { get; set; }
    }
}

