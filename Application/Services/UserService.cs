using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using BCrypt.Net;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepo;
    private readonly IUserAccessRepository _UserAccessRepo;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepo, IUserAccessRepository userAccessRepo, IMapper mapper)
    {
        _userRepo = userRepo;
        _UserAccessRepo = userAccessRepo;
        _mapper = mapper;
    }

    public async Task<UserDto> AddAsync(CreateUserDto dto)
    {
        var existingUser = await _userRepo.GetByEmailAsync(dto.Email);
        if (existingUser != null)
            throw new Exception("Já existe um usuário com este email.");

        var user = _mapper.Map<User>(dto);
        user.Password = BCrypt.Net.BCrypt.HashPassword(dto.Password);

        await _userRepo.AddAsync(user);

        foreach (var acesso in dto.Acessos)
        {
            var role = new UserAccess
            {
                UserId = user.Id,
                Sistema = acesso.Sistema,
                Role = acesso.Role
            };
            await _UserAccessRepo.AddAsync(role);
        }

        var acessosCriados = await _UserAccessRepo.GetByUserIdAsync(user.Id);
        var result = _mapper.Map<UserDto>(user);
        result.Acessos = acessosCriados.Select(x => new CreatUserAccessInUserDto
        {
            Sistema = x.Sistema,
            Role = x.Role
        }).ToList();

        return result;
    }

    public async Task<IEnumerable<UserDto>> GetAllAsync()
    {
        var users = await _userRepo.GetAllAsync();
        return _mapper.Map<IEnumerable<UserDto>>(users);
    }

}
