using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Shared.Mapping;

public class SistemaProfile : Profile
{
    public SistemaProfile()
    {
        CreateMap<Sistema, SistemaDto>();
        CreateMap<SistemaDto, Sistema>();
    }
}
