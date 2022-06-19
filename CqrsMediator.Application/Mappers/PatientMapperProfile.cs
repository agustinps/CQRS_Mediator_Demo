using AutoMapper;
using CqrsMediator.Application.DTOs;
using CqrsMediator.Domain.Entities;

namespace CqrsMediator.Application.Mappers
{
    public class PatientMapperProfile : Profile
    {
        public PatientMapperProfile()
        {
            CreateMap<Patient, PatientResponseDto>().ReverseMap();
            CreateMap<Patient, PatientCreateDto>().ReverseMap();
        }
    }
}
