using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_CENTRO_MEDICO.MODELOS;
using API_CENTRO_MEDICO.DATOS;

namespace API_CENTRO_MEDICO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : Controller
    {
        [HttpPost]
        [Route("Categoria")]
        public void AltaArea([FromBody] MArea Area)
        {
            var agregarArea = new DArea();
            agregarArea.AgragrArea(Area);
        }

        [HttpGet]
        [Route("AreasMedicas")]
        public List<MArea> AreasMedicas()
        {
            DArea areas = new DArea();
            var datosArea = areas.getAreas();


            List<MArea> lstAreas = new List<MArea>();
            while (datosArea.Read())
            {
                MArea Areas = new MArea();
                Areas.IdArea = (int)datosArea["idArea"];
                Areas.NombreArea = (string)datosArea["NombreArea"];
                lstAreas.Add(Areas);
            }

            return lstAreas;
        }
    }
}
