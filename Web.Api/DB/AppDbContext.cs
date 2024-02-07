// Copyright (c) IUA. All rights reserved.

namespace Web.Api.DB;

using Microsoft.EntityFrameworkCore;
using Web.Api.Model;

/// <summary>
/// App DbContext.
/// </summary>
public class AppDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AppDbContext"/> class.
    /// </summary>
    public AppDbContext()
    {
        this.Database.EnsureCreated();
    }

    /// <summary>
    /// Gets or sets the car.
    /// </summary>
    public DbSet<Car> Car { get; set; }

    /// <inheritdoc/>
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=web.db;");
    }

    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
