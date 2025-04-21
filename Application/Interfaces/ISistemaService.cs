using Application.DTOs;

namespace Application.Interfaces;

public interface ISistemaService
{
    Task<IEnumerable<SistemaDto>> GetAllAsync();
    Task AddAsync(CreateSistemaDto dto);
}
