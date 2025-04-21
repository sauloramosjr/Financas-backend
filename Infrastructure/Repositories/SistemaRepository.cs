using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class SistemaRepository : ISistemaRepository
{
    private readonly AppDbContext _context;

    public SistemaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Sistema sistema)
    {
        await _context.Sistema.AddAsync(sistema);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Sistema>> GetAllAsync()
    {
        return await _context.Sistema.ToListAsync();
    }
}
