using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using INTERFAZ_CENTRO_MEDICO.Modelos;

namespace INTERFAZ_CENTRO_MEDICO.API_REQUEST
{
    class Twillio
    {

        public void enviarMensaje(dynamic Telefono)
        {


            string accountSid = "ACb7667c8a95b7f6f530298b040480c931";
            string authToken = "9428ca9c2e909d2ca2c8d4e38498e4cc";


            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Heloo",
                from: new Twilio.Types.PhoneNumber("+12526756880"),
                to: new Twilio.Types.PhoneNumber($"+52{Telefono}")
            );
        }
        
    }
}
