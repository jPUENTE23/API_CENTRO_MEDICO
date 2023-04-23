using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using ClienteConsola.Modelos;

namespace ClienteConsola
{   
    internal class Program
    {

        static HttpClient client = new HttpClient();
        static async Task<Uri> CreateProductAsync(MPaciente Paciente)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("Paciente/AltaPaciente", Paciente);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://localhost:7168/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Create a new product
                MPaciente paciente = new MPaciente
                {
                    Nombre = "David",
                    Apaterno = "Puente",
                    Amaterno = "Muñiz",
                    Edad = 17,
                    Sexo = "M"
                };

                var url = await CreateProductAsync(paciente);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
