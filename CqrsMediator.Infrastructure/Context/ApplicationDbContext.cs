using CqrsMediator.Domain.Entities;
using CqrsMediator.Infrastructure.Context.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CqrsMediator.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
        }

        public DbSet<Patient> Patients { get; set; }
    }
}
