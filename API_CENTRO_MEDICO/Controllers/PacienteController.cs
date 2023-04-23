using Microsoft.AspNetCore.Mvc;
using API_CENTRO_MEDICO.MODELOS;
using API_CENTRO_MEDICO.DATOS;


namespace API_CENTRO_MEDICO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : ControllerBase
    {
        [HttpPost]
        [Route("AltaPaciente")]
        public void AltaPaciente([FromBody] MPaciente Paciente)
        {
            var registroPac = new DPaciente();
            registroPac.GuardarPaciente(Paciente);
        }
    }
}