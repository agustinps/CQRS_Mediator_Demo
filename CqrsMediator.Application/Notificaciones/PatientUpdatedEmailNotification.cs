using MediatR;

namespace CqrsMediator.Application.Notificaciones
{
    public record PatientUpdatedEmailNotification(int id) : INotification;
    
}
