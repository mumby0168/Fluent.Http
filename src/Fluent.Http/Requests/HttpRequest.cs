using System.Net.Http;

namespace Fluent.Http.Requests
{
    public class HttpRequest
    {

        public HttpRequestMessage Message { get; set; } = new();

        public HttpRequest(HttpRequestMessage message)
            => Message = message;

        public HttpRequest() { }

    }
}