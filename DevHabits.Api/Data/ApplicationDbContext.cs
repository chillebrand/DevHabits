using DevHabits.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevHabits.Api.Data;

public sealed class ApplicationDbContext : DbContext
{
    public DbContextOptions<ApplicationDbContext> Options { get; init; }

    public DbSet<Habit> Habits { get; set; }

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schemas.ApplicationSchema);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
