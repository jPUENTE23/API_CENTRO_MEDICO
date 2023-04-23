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
            string url = "https://localhost:7168/Categoria/AreasMedicas";

            using (var httpCliente = new HttpClient())
            {
                List<MArea> lstAreas = new List<MArea>();
                HttpResponseMessage responseAreas = await httpCliente.GetAsync(url);

                if (responseAreas.IsSuccessStatusCode)
                {
                    lstAreas =  await responseAreas.Content.ReadAsAsync<List<MArea>>();
                }

                return lstAreas;
            } 
        }

    }
}
