using CqrsMediator.Domain.Entities;
using CqrsMediator.Domain.Repositories;
using CqrsMediator.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CqrsMediator.Infrastructure.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext context;

        public PatientRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<int> CreatePatient(Patient Patient)
        {
            if (context.Patients.Any(x => x.DNI == Patient.DNI))
                throw new Exception("Registro ya existe");
            await context.Patients.AddAsync(Patient);
            await context.SaveChangesAsync();
            return Patient.Id;
        }

        public async Task DeletePatient(int id)
        {
            var p = context.Patients.Find(id);
            if (p != null)
                context.Patients.Remove(p);
            else
                throw new Exception("El registro no existe");
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Patient>> GetAll()
        {
            return await context.Patients.ToListAsync();
        }

        public async Task<Patient> GetById(int id)
        {
            return await context.Patients.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Patient> UpdateEmailPatient(int id, string email)
        {
            var p = context.Patients.Find(id);
            if (p == null)
                throw new Exception("registro no existe");
            p.Email = email;
            await context.SaveChangesAsync();
            return p;
        }

        public async Task<Patient> UpdateNotesPatient(int id, string note)
        {
            var p = context.Patients.Find(id);
            if (p == null)
                throw new Exception("registro no existe");
            p.Notes += note;
            await context.SaveChangesAsync();
            return p;
        }
    }
}
