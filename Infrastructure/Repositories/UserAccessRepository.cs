using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserAccessRepository : IUserAccessRepository
{
    private readonly AppDbContext _context;

    public UserAccessRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(UserAccess access)
    {
        await _context.UserAccesses.AddAsync(access);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<UserAccess>> GetByUserIdAsync(Guid userId)
    {
        return await _context.UserAccesses
            .Where(a => a.UserId == userId)
            .ToListAsync();
    }
    public async Task<UserAccess?> GetByIdAsync(Guid userAccessId)
    {
        return await _context.UserAccesses
            .FirstOrDefaultAsync(a => a.Id == userAccessId);
    }

    public async Task DeleteByUserIdAsync(Guid userId)
    {
        var existing = _context.UserAccesses.Where(a => a.UserId == userId);
        _context.UserAccesses.RemoveRange(existing);
        await _context.SaveChangesAsync();
    }
}
