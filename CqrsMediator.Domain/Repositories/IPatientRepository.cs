using CqrsMediator.Domain.Entities;

namespace CqrsMediator.Domain.Repositories
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAll();
        Task<Patient> GetById(int id);
        Task<int> CreatePatient(Patient Patient);
        Task<Patient> UpdateEmailPatient(int id, string email);
        Task DeletePatient(int id);
        Task<Patient> UpdateNotesPatient(int id, string note);
    }
}
