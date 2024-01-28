using BuilkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;


namespace BuilkyBookWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<Category> categories { get; set; }
    }
}
