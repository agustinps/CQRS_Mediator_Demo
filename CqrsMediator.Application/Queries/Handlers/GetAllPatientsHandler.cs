using AutoMapper;
using CqrsMediator.Application.DTOs;
using CqrsMediator.Infrastructure.Repositories;
using MediatR;

namespace CqrsMediator.Application.Queries.Handlers
{
    public class GetAllPatientsHandler : IRequestHandler<GetAllPatientsQuery, IEnumerable<PatientResponseDto>>
    {
        private readonly IMapper mapper;
        private readonly PatientRepository PatientRepository;

        public GetAllPatientsHandler(IMapper mapper, PatientRepository PatientRepository)
        {
            this.mapper = mapper;
            this.PatientRepository = PatientRepository;
        }

        public async Task<IEnumerable<PatientResponseDto>> Handle(GetAllPatientsQuery request, CancellationToken cancellationToken)
        {
            return mapper.Map<IEnumerable<PatientResponseDto>>(await PatientRepository.GetAll());
        }
    }
}
