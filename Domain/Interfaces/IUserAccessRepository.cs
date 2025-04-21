using Domain.Entities;

namespace Domain.Interfaces;

public interface IUserAccessRepository
{
    Task AddAsync(UserAccess entity);
    Task<IEnumerable<UserAccess>> GetByUserIdAsync(Guid userId);
    Task<UserAccess?> GetByIdAsync(Guid userAccessId);

}
