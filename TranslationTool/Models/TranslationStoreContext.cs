using Microsoft.EntityFrameworkCore;

namespace TranslationTool.Models
{
    public class TranslationStoreContext : DbContext
    {
        public TranslationStoreContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Text> Text { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Text>().HasKey(t => t.Key);
            modelBuilder.Entity<Text>().HasMany(t => t.Translations);
        }
    }
}
