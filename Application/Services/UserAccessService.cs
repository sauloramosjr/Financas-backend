using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using BCrypt.Net;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class UserAccessService : IUserAccessService
{
    private readonly IUserAccessRepository _userAccessRepo;
    private readonly IMapper _mapper;

    public UserAccessService(IUserAccessRepository userAccessRepo, IMapper mapper)
    {
        _userAccessRepo = userAccessRepo;
        _mapper = mapper;
    }

    public async Task AddAsync(CreateUserAccessDto dto)
    {

        var userAccess = _mapper.Map<UserAccess>(dto);

        await _userAccessRepo.AddAsync(userAccess);

    }

    public async Task<IEnumerable<UserAccessDto>> GetByUserIdAsync(Guid userID)
    {
        var acessos = await _userAccessRepo.GetByUserIdAsync(userID);
        return _mapper.Map<IEnumerable<UserAccessDto>>(acessos);
    }

}
