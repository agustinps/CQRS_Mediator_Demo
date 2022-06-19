using AutoMapper;
using CqrsMediator.Application.DTOs;
using CqrsMediator.Infrastructure.Repositories;
using MediatR;

namespace CqrsMediator.Application.Queries.Handlers
{
    public class GetPatientByIdHandler : IRequestHandler<GetPatientByIdQuery, PatientResponseDto>
    {
        private readonly IMapper mapper;
        private readonly PatientRepository PatientRepository;

        public GetPatientByIdHandler(IMapper mapper, PatientRepository PatientRepository)
        {
            this.mapper = mapper;
            this.PatientRepository = PatientRepository;
        }
        public async Task<PatientResponseDto> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
        {
            return mapper.Map<PatientResponseDto>(await PatientRepository.GetById(request.id));
        }
    }
}
