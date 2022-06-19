using CqrsMediator.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CqrsMediator.Infrastructure.Context.Configuration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.DNI).IsRequired();            
            //builder.HasData(
            //    new Patient
            //    {
            //        Id = 1,
            //        Name = "Patient 1",
            //        Surname = "Surname 1",
            //        Address = "Address Patient 1",
            //        DNI = "12345678X",
            //        Email = "patient1@email.com",
            //        FechaNacimiento = DateTime.Today.AddYears(-32),
            //    },
            //    new Patient
            //    {
            //        Id=2,
            //        Name = "Patient 2",
            //        Surname = "Surname 2",
            //        Address = "Address Patient 2",
            //        DNI = "99999999Z",
            //        Email = "patient2@email.com",
            //        FechaNacimiento = DateTime.Today.AddYears(-23),
            //    }
            //    );
        }
    }
}
