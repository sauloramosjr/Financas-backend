using Domain.Entities;

namespace Domain.Interfaces;

public interface ISistemaRepository
{
    Task<IEnumerable<Sistema>> GetAllAsync();
    Task AddAsync(Sistema user);
}
