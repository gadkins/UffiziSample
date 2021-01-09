using Microsoft.EntityFrameworkCore;
using SampleApplication.Models;

namespace SampleApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Joke> Joke { get; set; }
    }
}
