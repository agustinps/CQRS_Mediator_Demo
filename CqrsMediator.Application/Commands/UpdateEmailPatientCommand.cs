using CqrsMediator.Application.DTOs;
using MediatR;

namespace CqrsMediator.Application.Commands
{
    public record UpdateEmailPatientCommand(int id, string email) : IRequest<PatientResponseDto>;
    
}
