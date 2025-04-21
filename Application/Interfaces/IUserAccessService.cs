using Application.DTOs;

namespace Application.Interfaces;

public interface IUserAccessService
{
    Task<IEnumerable<UserAccessDto>> GetByUserIdAsync(Guid userId);
    Task AddAsync(CreateUserAccessDto dto);
}
