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

        [HttpGet]
        [Route("Mostrar_Pacientes")]
        public List<MPaciente> ListarPacientes()
        {
            var funcionPacinete = new DPaciente();
            var paciente = funcionPacinete.MostratPacientes();

            List<MPaciente> lstPacientes = new List<MPaciente>();

            while (paciente.Read())
            {
                MPaciente Pac = new MPaciente();
                Pac.idPaciente = (int)paciente["IdPaciente"];
                Pac.Nombre = (string)paciente["Nombre"];
                Pac.Apaterno = (string)paciente["Apaterno"];
                Pac.Amaterno = (string)paciente["Amaterno"];
                Pac.Edad = (int)paciente["Edad"];
                Pac.Sexo = (string)paciente["Sexo"];
                lstPacientes.Add(Pac);
            }

            return lstPacientes;
        }
    }
}