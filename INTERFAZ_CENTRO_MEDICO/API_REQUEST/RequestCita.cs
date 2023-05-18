using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using INTERFAZ_CENTRO_MEDICO.Modelos;

namespace INTERFAZ_CENTRO_MEDICO.API_REQUEST
{
    class RequestCita
    {
        public async Task<HttpResponseMessage> AgregarCita (MCita Cita)
        {
            string url = "https://localhost:7168/Cita/RegistrarCita";

            using (var httpCliente = new HttpClient())
            {

                HttpResponseMessage response = await httpCliente.PostAsJsonAsync(url, Cita);

                return response;
            }
        }
    }
}
