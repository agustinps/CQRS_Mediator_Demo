using AutoMapper;
using CqrsMediator.Infrastructure.Repositories;
using MediatR;

namespace CqrsMediator.Application.Commands.Handlers
{
    public class DeletePatientHandler : IRequestHandler<DeletePatientCommand, Unit>
    {
        private readonly IMapper mapper;
        private readonly PatientRepository Patientrespository;

        public DeletePatientHandler(IMapper mapper, PatientRepository Patientrespository)
        {
            this.mapper = mapper;
            this.Patientrespository = Patientrespository;
        }
        public async Task<Unit> Handle(DeletePatientCommand request, CancellationToken cancellationToken)
        {
            await Patientrespository.DeletePatient(request.id);

            return Unit.Value;
        }
    }
}
