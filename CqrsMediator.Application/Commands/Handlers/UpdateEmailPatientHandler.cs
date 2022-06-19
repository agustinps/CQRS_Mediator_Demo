using AutoMapper;
using CqrsMediator.Application.DTOs;
using CqrsMediator.Infrastructure.Repositories;
using MediatR;

namespace CqrsMediator.Application.Commands.Handlers
{
    public class UpdateEmailPatientHandler : IRequestHandler<UpdateEmailPatientCommand, PatientResponseDto>
    {
        private readonly IMapper mapper;
        private readonly PatientRepository PatientRespository;

        public UpdateEmailPatientHandler(IMapper mapper, PatientRepository PatientRespository)
        {
            this.mapper = mapper;
            this.PatientRespository = PatientRespository;
        }
        public async Task<PatientResponseDto> Handle(UpdateEmailPatientCommand request, CancellationToken cancellationToken)
        {
            return  mapper.Map<PatientResponseDto>(await PatientRespository.UpdateEmailPatient(request.id, request.email));
        }
    }
}
