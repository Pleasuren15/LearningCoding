using LearningCoding.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningCoding.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProgrammingLanguage>().ToTable("ProgrammingLanguage");
        }
    }
}
