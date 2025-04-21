using Application.DTOs;

namespace Application.Interfaces;

public interface IRoleService
{
    Task<IEnumerable<RoleDto>> GetAllAsync();
    Task AddAsync(CreateRoleDto dto);
}
