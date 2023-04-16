using Microsoft.AspNetCore.Mvc;
using API_CENTRO_MEDICO.MODELOS;
using API_CENTRO_MEDICO.DATOS;

namespace API_CENTRO_MEDICO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : Controller
    {
        [HttpPost]
        [Route("AltaDoctor")]
        public void AltaDoctor([FromBody] MDoctor Doctor )
        {
            var altaDoctor = new DDoctor();
            altaDoctor.AgregarDoctor(Doctor);
        }
    }
}
