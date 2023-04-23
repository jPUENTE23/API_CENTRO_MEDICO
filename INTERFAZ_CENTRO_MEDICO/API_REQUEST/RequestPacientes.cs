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
        static HttpClient client = new HttpClient();
        static void IniciarCliente()
        {
            client.BaseAddress = new Uri("https://localhost:7168/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        static async Task<Uri> AltaPaciente(MPaciente Paciente)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("Paciente/AltaPaciente", Paciente);
            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }

        public void AgregarPaciente(MPaciente DatosPaciente)
        {
            IniciarCliente();
            try
            {

                MPaciente paciente = new MPaciente();
                paciente.Nombre = DatosPaciente.Nombre;
                paciente.Apaterno = DatosPaciente.Apaterno;
                paciente.Amaterno = DatosPaciente.Amaterno;
                paciente.Edad = DatosPaciente.Edad;
                paciente.Sexo = DatosPaciente.Sexo;

                var response = AltaPaciente(paciente);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
