using CqrsMediator.Infrastructure.Repositories;

namespace CqrsMediator.Application.Services
{
    public class SendEmail : ISendEmail
    {

        //habría que enviar un mail pero no lo hacemos y para mostrar que se ejecutó el evento, modificamos el campo notas de Patient

        private readonly PatientRepository PatientRepository;

        public SendEmail(PatientRepository PatientRepository)
        {
            this.PatientRepository = PatientRepository;            
        }

        public async Task UpdateNotes(int id) =>await PatientRepository.UpdateNotesPatient(id, " - Añadimos texto de evento simulación envío mail - ");        

    }
}
