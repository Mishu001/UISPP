using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UISPP.Models;

namespace UISPP.DataServices
{
    public class RestDataService : IRestDataService
    {

        private readonly HttpClient _httpClient;
        private readonly string _baseAddress;
        private readonly string _url;

        public RestDataService()
        {
            HttpsClientHandlerService handler = new HttpsClientHandlerService();
            _httpClient = new HttpClient(handler.GetPlatformMessageHandler());
            _baseAddress = "http://10.0.2.2:5225";
            _url = $"{_baseAddress}/api";

        }



        public Task<List<Presentation>> GetAllPresentations()
        {
            throw new NotImplementedException();
        }

        public async Task GetPresentationById(int id)
        {
            Presentation presentation = new Presentation();

            string url = $"https://192.168.0.133:7024/api/presentations/{id}";
            _httpClient.BaseAddress= new Uri(url);
            HttpResponseMessage response  = await _httpClient.GetAsync(url);
            if(response.IsSuccessStatusCode)
            {
                
            }
        }

        public async Task<List<Presentation>> GetPresentationsByEventId()
        {
            List<Presentation> presentations = new List<Presentation>();

            string url = "https://192.168.0.133:7024/api/presentations/event/1";
            _httpClient.BaseAddress = new Uri(url);
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if(response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                presentations = JsonConvert.DeserializeObject<List<Presentation>>(content);
                return presentations;
            }
            return null;
        }
    }
}
