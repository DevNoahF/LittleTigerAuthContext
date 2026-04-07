using AuthContext.Context.Auth.Entities;
using AuthContext.Context.Auth.ValueObject;
using Microsoft.EntityFrameworkCore;

namespace AuthContext.Context.Auth.Persistence;

public class AuthDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(u => u.Id);
            
            entity.Property(u => u.Email)
                .HasConversion(
                    email => email.Value,
                    value => new Email(value));

            entity.Property(u => u.Password)
                .HasConversion(
                    password => password.Value,
                    value => new Password(value));

            entity.Property(u => u.Token)
                .IsRequired(false);

            entity.Property(u => u.Role)
                .IsRequired(false)
                .HasMaxLength(50);
        });
        
        base.OnModelCreating(modelBuilder);
    }
}