using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Event> Events { get; set; } = null!;
    public DbSet<Resource> Resources { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>().Ignore(e => e.Resource );
        modelBuilder.Entity<Resource>().Ignore(e => e.Events );
        modelBuilder.Entity<Resource>().Ignore(e => e.HomeResource );
        modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
        modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
        modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();
        
            //modelBuilder.Entity<Event>()
            //.Resource(s => s.EventId)
            //.HasColumnName("Id")
            //.HasDefaultValue(0)
            //.IsRequired();
    }
    
    
    
}