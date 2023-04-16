using Microsoft.AspNetCore.Mvc;
using API_CENTRO_MEDICO.MODELOS;
using API_CENTRO_MEDICO.DATOS;



namespace API_CENTRO_MEDICO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacturacionController : Controller
    {
        [HttpPost]
        [Route("GenFactura")]
        public void GenerarFac([FromBody] MFacturacion Factura )
        {
            var genFact = new DFacturacion();
            genFact.GenrarFactura(Factura);
        }
    }
}
