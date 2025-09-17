using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_interface
{
    public class HttpServices<T> : IHttpServices<T> where T : class
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseEndpoint;

        public HttpServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseEndpoint = $"api/{typeof(T).Name.ToLower().Replace("dto", "")}s"; 
        }
        public async Task<List<T>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(_baseEndpoint);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<T>>(content);
        }

        public async Task<T> GetAsync(Guid id)
        {
            var response = await _httpClient.GetAsync($"{_baseEndpoint}/{id}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public async Task AddAsync(T entity)
        {
            var json = JsonConvert.SerializeObject(entity);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_baseEndpoint, content);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(T entity)
        {
            var json = JsonConvert.SerializeObject(entity);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(_baseEndpoint, content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"{_baseEndpoint}/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
