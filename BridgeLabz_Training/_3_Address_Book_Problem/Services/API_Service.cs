// UC-15: Read/Write data to JSONServer / Web API

using System.Net.Http;
using System.Text;
using System.Text.Json;
using BridgeLabz_Training._3_Address_Book_Problem.Models

namespace BridgeLabz_Training._3_Address_Book_Problem.Services {

    public class API_Service : IData_Service
    {
        private readonly HttpClient _client = new();
        private readonly string _url = "http://localhost:3000/addressbooks";

        public async Task SaveAsync(Dictionary<string, List<Contact>> addressBooks)
        {
            var json = JsonSerializer.Serialize(addressBooks);
            await _client.PostAsync(_url, new StringContent(json, Encoding.UTF8, "application/json"));
        }

        public async Task<Dictionary<string, List<Contact>>> LoadAsync()
        {
            try
            {
                var r = await _client.GetStringAsync(_url);
                return JsonSerializer.Deserialize<Dictionary<string, List<Contact>>>(r) ?? new();
            }
            catch { return new(); }
        }
    }
}