namespace CqrsMediator.Application.DTOs
{
    public class PatientCreateDto
    {        
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
