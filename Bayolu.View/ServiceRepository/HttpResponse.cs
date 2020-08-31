using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bayolu.View.ServiceRepository
{
    public class HttpResponse<T>
    {
        public HttpStatusCode Code;
        public string Message;
        public T Item { get; set; }
        HttpResponseMessage _message;
        public HttpResponse(HttpResponseMessage message)
        {
            _message = message;
            Code = message.StatusCode;
            if (Code != HttpStatusCode.OK)
            {
                throw new BadException(message);
            }
        }

        public async Task<HttpResponse<T>> SetItem()
        {
            var content = await _message.Content.ReadAsStringAsync();
            Item = JsonConvert.DeserializeObject<T>(content);
            return this;
        }
    }
}
