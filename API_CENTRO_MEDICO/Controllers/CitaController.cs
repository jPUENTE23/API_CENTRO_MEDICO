using API_CENTRO_MEDICO.MODELOS;
using API_CENTRO_MEDICO.DATOS;


using Microsoft.AspNetCore.Mvc;

namespace API_CENTRO_MEDICO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitaController : Controller
    {
        [HttpPost]
        [Route("RegistrarCita")]
        public void RegistrarCita([FromBody] MCita Cita)
        {
            var agrCita = new DCitas();
            agrCita.RegistrarCita(Cita);
        }
    }
}
