using CqrsMediator.Application.Commands;
using CqrsMediator.Application.DTOs;
using CqrsMediator.Application.Notificaciones;
using CqrsMediator.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IMediator mediator;        

        public PatientController(IMediator mediator)
        {
            this.mediator = mediator;            
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<PatientResponseDto>>> GetAll() => Ok(await mediator.Send(new GetAllPatientsQuery()));

        [HttpGet("[action]/{id:int}")]
        public async Task<ActionResult<IEnumerable<PatientResponseDto>>> GetById(int id)
        {
            var patient = await mediator.Send(new GetPatientByIdQuery(id));
            if (patient is null)
                return NotFound("Registro no existe");
            return Ok(patient);
        }

        [HttpDelete("[action]/{id:int}")]
        public async Task<ActionResult> Delete(int id) => Ok(await mediator.Send(new DeletePatientCommand(id)));

        [HttpPost("[action]")]
        public async Task<ActionResult> Create([FromBody]PatientCreateDto Patient)
        {
            int idPatient = await mediator.Send(new CreatePatientCommand(Patient));
            return CreatedAtAction("GetById", new { id = idPatient }, Patient);
        }

        [HttpPatch("[action]")]
        public async Task<PatientResponseDto> UpdateEmail(int id, string email)
        {
            var Patient = await mediator.Send(new UpdateEmailPatientCommand(id, email));

            //Publicamos envento para enviar email y notificar el cambio
            await mediator.Publish(new PatientUpdatedEmailNotification(Patient.Id));

            return Patient;
        }

    }
}
