using System;
using System.Net;
using System.Net.Http;

namespace Bayolu.View.ServiceRepository
{
    public class BadException : Exception
    {
        public HttpStatusCode Code;
        public BadException(HttpResponseMessage message) : base(message.Content.ToString())
        {
            Code = message.StatusCode;
        }
    }
}
