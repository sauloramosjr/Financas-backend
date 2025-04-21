using Domain.Entities;

namespace Domain.Interfaces;

public interface IRoleRepository
{
    Task<IEnumerable<Role>> GetAllAsync();
    Task AddAsync(Role user);
}
