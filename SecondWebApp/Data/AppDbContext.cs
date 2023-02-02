using Microsoft.EntityFrameworkCore;
using SecondWebApp.Models;

namespace SecondWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<ClientCount> ClientCounts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Prodact> Prodacts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Tesimonial> Tesimonials { get; set; }
        public DbSet<Blog> Blogs {get; set;}

    }
}
