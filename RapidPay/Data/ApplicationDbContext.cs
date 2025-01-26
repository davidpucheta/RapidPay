using Microsoft.EntityFrameworkCore;
using RapidPay.Model.Data;

namespace RapidPay.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Card> Cards { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Card>().ToTable("Card");
    }
}