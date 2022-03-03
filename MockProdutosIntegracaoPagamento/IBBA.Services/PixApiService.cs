using IBBA.Services.DTO;
using IBBA.Services.DTO.pagamento;
using IBBA.Services.DTO.qrcode;
using IBBA.Services.DTO.token;
using IBBA.Services.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBBA.Services
{
    public class PixApiService : IPixApiService
    {
        public string ClienteId { get; private set; }
        public string ClienteSecret { get; private set; }
        public string UrlAPI { get; set; }

        public PixApiService()
        {
            ClienteId = "6173eeb3-97c8-4909-97b1-3603c092a388";
            ClienteSecret = "04f7290c-d34b-4aa5-8779-5099b96627a8";

            UrlAPI = "https://api.itau.com.br/sandbox/";
        }
        
        public token GerarToken()
        {
            var endPoint = "https://api.itau.com.br/sandbox/api/oauth/token";
            
            var client = new RestClient();

            var request = new RestRequest(endPoint, Method.Post);           

            request.AddHeader("content-type", "application/x-www-form-urlencoded");            
            request.AddParameter("grant_type", "client_credentials", ParameterType.GetOrPost);
            request.AddParameter("client_id", ClienteId, ParameterType.GetOrPost);
            request.AddParameter("client_secret", ClienteSecret, ParameterType.GetOrPost);

            var response = client.ExecuteAsync(request);

            var res = JsonConvert.DeserializeObject<token>(response.Result.Content); 

            return res;
        }

        public NovoPagamentoDTO GerarPedido(string token, DadosEnvioPixDTO model)
        {
            var endPoint = "pix_recebimentos/v2/cob";

            var client = new RestClient(UrlAPI);
            client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(token, "Bearer");

            var request = new RestRequest(endPoint, Method.Post);
                         
            //Não é necessário fazer a serialização do objeto, o endpoint do ITAU não aceita se estiver serializado.

            request.AddJsonBody(model);

            var response = client.ExecuteAsync(request);

            var responseGerarPedido = JsonConvert.DeserializeObject<NovoPagamentoDTO>(response.Result.Content);

            return responseGerarPedido;
        }

        public PixQRCodeDTO ObterQRCodePixPor(string txid, string token)
        {
            var endPoint = "pix_recebimentos/v2/cob/";
            var pedidoQR = $"{txid}/qrcode";

            var client = new RestClient(UrlAPI);
            client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(token, "Bearer");

            var request = new RestRequest(endPoint + pedidoQR, Method.Get);
            var response = client.ExecuteAsync(request);

            var objetoQRCode = JsonConvert.DeserializeObject<PixQRCodeDTO>(response.Result.Content);

            return objetoQRCode;
        }




    }
}
