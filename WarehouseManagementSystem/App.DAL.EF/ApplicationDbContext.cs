using App.Domain;
using App.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF;

public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, Guid, IdentityUserClaim<Guid>, 
    AppUserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
{
    public DbSet<Flower> Flowers { get; set; } = default!;
    public DbSet<Warehouse> Warehouses { get; set; } = default!;
    
    public DbSet<AppRefreshToken> AppRefreshTokens { get; set; } = default!;
    
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        // disable cascade delete
        foreach (var foreignKey in builder.Model
                     .GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
        }
       
    }
}