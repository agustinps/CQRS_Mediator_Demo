using CqrsMediator.Application.Services;
using MediatR;

namespace CqrsMediator.Application.Notificaciones.Handlers
{
    public class PatientUpdatedEmailHandler : INotificationHandler<PatientUpdatedEmailNotification>
    {
        private readonly ISendEmail sendEmail;

        public PatientUpdatedEmailHandler(ISendEmail sendEmail)
        {
            this.sendEmail = sendEmail;
        }

        public async Task Handle(PatientUpdatedEmailNotification notification, CancellationToken cancellationToken)
        {
            await sendEmail.UpdateNotes(notification.id);
        }
    }
}
