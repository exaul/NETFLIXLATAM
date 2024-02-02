using Microsoft.EntityFrameworkCore;
using NETFLIXLATAM.Models;

namespace NETFLIXLATAM.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public DbSet<Peliculas> Peliculas { get; set; }

    }
}
