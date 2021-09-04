using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace Fluent.Http
{
    public class HttpRequestMessageBuilder
    {
        public HttpRequestMessage Message { get; } = new();

        public HttpRequestMessageBuilder WithUrl(string url)
        {
            Message.RequestUri = new Uri(url);
            return this;
        }

        public HttpRequestMessageBuilder WithJsonBody<TBody>(TBody body, JsonSerializerSettings? jsonSerializerSettings = null)
        {
            Message.Content = new StringContent(JsonConvert.SerializeObject(body, jsonSerializerSettings), Encoding.UTF8, FluentHttpConstants.ApplicationJson);
            return this;
        }

        public HttpRequestMessageBuilder WithMethod(HttpMethod method)
        {
            Message.Method = method;
            return this;
        }

        public HttpRequestMessageBuilder WithMethod(string method)
        {
            Message.Method = new HttpMethod(method.ToUpper());
            return this;
        }
    }
}