﻿using Microsoft.EntityFrameworkCore;
using Models.Model.Data;

namespace Data.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Card> Cards { get; set; }
    public DbSet<User> Users { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Card>().ToTable("Card");
        modelBuilder.Entity<User>(e => e.HasData([
            new User
            {
                Id = 101,
                UserName = "ApiUser",
                Password = "123456"
            }
        ]));
    }
}