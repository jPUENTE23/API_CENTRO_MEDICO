using Microsoft.AspNetCore.Mvc;
using API_CENTRO_MEDICO.MODELOS;
using API_CENTRO_MEDICO.DATOS;
using System.Data.SqlClient;

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

        [HttpGet]
        [Route("Doctores_Registrados")]
        public List<MDoctor> DoctoresReg()
        {
            var datosDoctores = new DDoctor();
            var doctores = datosDoctores.ListarDoctores();

            List<MDoctor> lstDoctores = new List<MDoctor>();

            while (doctores.Read())
            {
                MDoctor Doc = new MDoctor();
                Doc.IdDoctor = (int)doctores["IdDoctor"];
                Doc.Nombre = (string)doctores["Nombre"];
                Doc.Apeterno = (string)doctores["Apaterno"];
                Doc.Amaterno = (string)doctores["Amaterno"];
                Doc.Edad = (int)doctores["Edad"];
                Doc.Sexo = (string)doctores["Sexo"];
                Doc.IsActivo = (int)doctores["IsActivo"];
                Doc.IdArea = (string)doctores["NombreArea"];
                lstDoctores.Add(Doc);
            }
            return lstDoctores;
        }

        [HttpDelete]
        [Route("EliminarDoctor/{idDoctor}")]
        public IActionResult elimnarDoctor(int idDoctor)
        {
            var funcionDoctor = new DDoctor();
            funcionDoctor.elimnarDoctor(idDoctor);

            return StatusCode(StatusCodes.Status200OK, new { response = "El registro se elimino corrractente" });
        }
    }
}
