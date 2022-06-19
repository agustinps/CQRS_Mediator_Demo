using AutoMapper;
using CqrsMediator.Domain.Entities;
using CqrsMediator.Infrastructure.Repositories;
using MediatR;

namespace CqrsMediator.Application.Commands.Handlers
{
    public class CreatePatientHandler : IRequestHandler<CreatePatientCommand, int>
    {
        private readonly IMapper mapper;
        private readonly PatientRepository PatientRepository;

        public CreatePatientHandler(IMapper mapper, PatientRepository PatientRepository)
        {
            this.mapper = mapper;
            this.PatientRepository = PatientRepository;
        }

        //este se comenta al cambiar el retorno de unit por int para obtener el id de la Patienta creada
        //public async Task<Unit> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        //{
        //    await PatientRepository.CreatePatient(mapper.Map<Patient>(request.Patient));

        //    return Unit.Value;
        //}

        public async Task<int> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            return await PatientRepository.CreatePatient(mapper.Map<Patient>(request.Patient));
        }
    }
}
