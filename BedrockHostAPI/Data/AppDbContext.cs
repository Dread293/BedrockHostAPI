using Microsoft.EntityFrameworkCore;
using BedrockHostAPI.Models;

namespace BedrockHostAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Rol> Roles { get; set; }
    }
}