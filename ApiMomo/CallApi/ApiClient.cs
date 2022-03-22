using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiMomo.CallApi
{
    public class ApiClient
    {
        private HttpClient httpClient;
        public HttpClient HttpClient
        {
            get { return httpClient; }
            set { httpClient = value; }
        }
        public ApiClient(string endpoint)
        {
            IntitiLize(endpoint);
        }

        public void IntitiLize(string endPoint)
        {
            if(HttpClient == null)
            {
                HttpClient = new HttpClient();
            }
            HttpRequestMessage = new HttpRequestMessage(HttpMethod.Post, endPoint);
            HttpRequestMessage.Headers.Add("Accept", "application/json");
           
            
 

        }
       public  HttpRequestMessage HttpRequestMessage { get; set; }
    }
}
