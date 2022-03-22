using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiMomo.CallApi
{
    public class RequestPayMent
    { 
      private ApiClient _client;
      public RequestPayMent(string endpoint)
        {
            _client = new ApiClient(endpoint);
        }
       public async Task<string> SendPayMentReques(string jsonMessage)
        {
            try
            {
                _client.HttpRequestMessage.Content = new StringContent(jsonMessage, Encoding.UTF8, "application/json");
                var response = await _client.HttpClient.SendAsync(_client.HttpRequestMessage);
                return await response.Content.ReadAsStringAsync();
            }
            catch(WebException ex)
            {
                return ex.Message;
            }
        }
    }
}
