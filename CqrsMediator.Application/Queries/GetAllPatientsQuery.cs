using CqrsMediator.Application.DTOs;
using MediatR;

namespace CqrsMediator.Application.Queries
{
    public record GetAllPatientsQuery() : IRequest<IEnumerable<PatientResponseDto>>;    
}
