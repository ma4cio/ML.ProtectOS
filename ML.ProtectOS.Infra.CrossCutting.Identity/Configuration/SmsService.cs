using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Twilio;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ML.ProtectOS.Infra.CrossCutting.Identity.Configuration
{
    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Utilizando TWILIO como SMS Provider.
            // https://www.twilio.com/docs/quickstart/csharp/sms/sending-via-rest

            const string accountSid = "SEU ID";
            const string authToken = "SEU TOKEN";            

            // Initialize the Twilio client
            TwilioClient.Init(accountSid, authToken);

            // Send an SMS message.
            var call = MessageResource.Create(
                    to: new PhoneNumber("+12069419717"),
                  from: new PhoneNumber("+14155992671"),
                  body: "This is my SMS message.");



            //var client = new TwilioRestClient(accountSid, authToken);

            //client.SendMessage("Seu Telefone", message.Destination, message.Body);

            return Task.FromResult(0);
        }
    }
}
