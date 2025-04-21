using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<UserAccess> UserAccesses => Set<UserAccess>();
    public DbSet<Sistema> Sistema=> Set<Sistema>();
    public DbSet<Role> Role => Set<Role>();
}
