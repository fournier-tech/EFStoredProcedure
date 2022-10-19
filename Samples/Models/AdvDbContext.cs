using Microsoft.EntityFrameworkCore;

namespace EFSample.Models {
  public class AdvDbContext : DbContext {
    public AdvDbContext(DbContextOptions<AdvDbContext> options) : base(options) {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<ScalarInt> ScalarIntValue { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<ScalarInt>().HasNoKey();
    }
  }
}