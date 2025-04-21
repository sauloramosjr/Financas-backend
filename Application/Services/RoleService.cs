using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using BCrypt.Net;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class RoleService : IRoleService
{
    private readonly IRoleRepository _roleRepo;
    private readonly IMapper _mapper;

    public RoleService(IRoleRepository roleRepo, IMapper mapper)
    {
        _roleRepo = roleRepo;
        _mapper = mapper;
    }

    public async Task AddAsync(CreateRoleDto dto)
    {

        var sistema = _mapper.Map<Role>(dto);

        await _roleRepo.AddAsync(sistema);

    }

    public async Task<IEnumerable<RoleDto>> GetAllAsync()
    {
        var acessos = await _roleRepo.GetAllAsync();
        return _mapper.Map<IEnumerable<RoleDto>>(acessos);
    }


}
