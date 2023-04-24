using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using INTERFAZ_CENTRO_MEDICO.Modelos;

namespace INTERFAZ_CENTRO_MEDICO.API_REQUEST
{
    class RequestDoctor
    {
        public async Task<HttpResponseMessage> AgregarDoctor(MDoctor datosDoctor)
        {
            string url = "https://localhost:7168/Doctor/AltaDoctor";

            using (var httpCliente = new HttpClient())
            {
                MDoctor Doctor = new MDoctor();
                Doctor.Nombre = datosDoctor.Nombre;
                Doctor.Apeterno = datosDoctor.Apeterno;
                Doctor.Amaterno = datosDoctor.Amaterno;
                Doctor.Edad = datosDoctor.Edad;
                Doctor.Sexo = datosDoctor.Sexo;
                Doctor.IsActivo = datosDoctor.IdArea;
                Doctor.IdArea = datosDoctor.IdArea;

                HttpResponseMessage response = await httpCliente.PostAsJsonAsync(url, Doctor);

                return response;
            }
        } 
    }
}
