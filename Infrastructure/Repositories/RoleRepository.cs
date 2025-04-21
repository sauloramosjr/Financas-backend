using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class RoleRepository : IRoleRepository
{
    private readonly AppDbContext _context;

    public RoleRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Role role)
    {
        await _context.Role.AddAsync(role);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Role>> GetAllAsync()
    {
        return await _context.Role.ToListAsync();
    }
}
