using Bayolu.ViewModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Bayolu.View.ServiceRepository
{
    public class BaseServiceRepository
    {
        private readonly HttpClient _httpClient;
        protected static string _baseUrl = "http://localhost:5001";
        protected static string _version = "v1";
        public BaseServiceRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        protected async Task<HttpResponse<UserViewModel>> Post<T>(string url, T model)
        {
            var furl = $"{_baseUrl}/{_version}{url}";
            var httpResponse = await _httpClient.PostAsJsonAsync(furl, model);
            var response = await new HttpResponse<UserViewModel>(httpResponse).SetItem();
            return response;
        }

        protected async Task<HttpResponse<T>> Get<T>(string url)
        {
            var furl = $"{_baseUrl}/{_version}{url}";
            var httpResponse = await _httpClient.GetAsync(furl);
            var response = await new HttpResponse<T>(httpResponse).SetItem();
            return response;
        }
    }
}
