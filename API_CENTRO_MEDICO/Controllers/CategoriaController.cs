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
    }
}
