using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using INTERFAZ_CENTRO_MEDICO.Modelos;
using System.Windows.Forms;


namespace INTERFAZ_CENTRO_MEDICO.API_REQUEST
{
    class RequestPaciente
    {
        public async Task<HttpResponseMessage> AgregarPaciente(MPaciente DatosPaciente)
        {
            /*Indicamos la url a la que mandaro los datos */
            string url = "https://localhost:7168/Paciente/AltaPaciente";
            using (var httpCliente = new HttpClient())
            {

                /*Almacenamos los datos que reciban los parametros del metodo */
                MPaciente paciente = new MPaciente();
                paciente.Nombre = DatosPaciente.Nombre;
                paciente.Apaterno = DatosPaciente.Apaterno;
                paciente.Amaterno = DatosPaciente.Amaterno;
                paciente.Edad = DatosPaciente.Edad;
                paciente.Sexo = DatosPaciente.Sexo;

                /*Mandamos los datos ingresados a la url indicada andicada anterior mente junn con el objeto que recolecto los datos*/
                HttpResponseMessage reponse = await httpCliente.PostAsJsonAsync(url, paciente);

                /*Reternoamos la respueste por parte del servidor */
                return reponse;
            }
        }
    }
}
