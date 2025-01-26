using Microsoft.EntityFrameworkCore;
using RapidPay.Model.Data;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RapidPay.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Card> Card { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Card>().ToTable("Card");
    }
}