using CqrsMediator.Application.DTOs;
using MediatR;

namespace CqrsMediator.Application.Commands
{
    public record CreatePatientCommand(PatientCreateDto Patient) : IRequest<int>;
    
}
