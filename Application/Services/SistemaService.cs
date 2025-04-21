using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using BCrypt.Net;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class SistemaService : ISistemaService
{
    private readonly ISistemaRepository _sistemaRepo;
    private readonly IMapper _mapper;

    public SistemaService(ISistemaRepository sistemaRepo, IMapper mapper)
    {
        _sistemaRepo = sistemaRepo;
        _mapper = mapper;
    }

    public async Task AddAsync(CreateSistemaDto dto)
    {

        var sistema = _mapper.Map<Sistema>(dto);

        await _sistemaRepo.AddAsync(sistema);

    }

    public async Task<IEnumerable<SistemaDto>> GetAllAsync()
    {
        var acessos = await _sistemaRepo.GetAllAsync();
        return _mapper.Map<IEnumerable<SistemaDto>>(acessos);
    }


}
