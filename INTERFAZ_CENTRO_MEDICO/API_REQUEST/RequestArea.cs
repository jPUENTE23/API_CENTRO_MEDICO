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
    class RequestArea
    {

        public async Task<List<MArea>> GetAreasMedicas()
        {
            /*Indicamos la url a la que mandaro los datos */
            string url = "https://localhost:7168/Categoria/AreasMedicas";
            using (var httpCliente = new HttpClient())
            {

                /*Creamos una nueva lista donde almacenaran los datos retornados */
                List<MArea> lstAreas = new List<MArea>();

                /*Hacemos una peticion para obtener los datos de la url*/
                HttpResponseMessage responseAreas = await httpCliente.GetAsync(url);


                if (responseAreas.IsSuccessStatusCode)
                {
                    /* Guardamos los datos en la lista creaado anteriormente */
                    lstAreas =  await responseAreas.Content.ReadAsAsync<List<MArea>>();
                }

                /*Retornamos la informacion */
                return lstAreas;
            } 
        }

    }
}
