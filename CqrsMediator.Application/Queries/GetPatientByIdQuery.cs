using CqrsMediator.Application.DTOs;
using MediatR;

namespace CqrsMediator.Application.Queries
{
    public record GetPatientByIdQuery(int id) : IRequest<PatientResponseDto>;
    
}
