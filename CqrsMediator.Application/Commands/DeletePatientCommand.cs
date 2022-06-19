using MediatR;

namespace CqrsMediator.Application.Commands
{
    public record DeletePatientCommand(int id) : IRequest<Unit>;
    
}
