using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class AutoRepairDataContext : IdentityDbContext
{
    public AutoRepairDataContext(DbContextOptions<AutoRepairDataContext> options) : base(options)
    {
    }

    //public DbSet<MyEntity> MyEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure the entity mappings here
    }
}