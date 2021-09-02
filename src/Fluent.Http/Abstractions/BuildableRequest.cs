using Fluent.Http.Requests;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace Fluent.Http.Abstractions
{
    public abstract class BuildableRequest
    {
        protected readonly FluentHttpOptions FluentHttpOptions;
        public HttpRequestMessage RequestMessage { get; set; } = new();

        protected BuildableRequest(HttpMethod method, FluentHttpOptions fluentHttpOptions)
        {
            FluentHttpOptions = fluentHttpOptions;
            RequestMessage.Method = method;
        }

        protected TRequest WithJsonBody<TBody, TRequest>(TBody body, TRequest request)
        {
            RequestMessage.Content = new StringContent(JsonConvert.SerializeObject(body, FluentHttpOptions.JsonSerializerSettings), Encoding.UTF8, FluentHttpConstants.ApplicationJson);
            return request;
        } 
        
        protected TRequest WithUri<TRequest>(Uri uri, TRequest request)
        {
            RequestMessage.RequestUri = uri;
            return request;
        }
        
        protected TRequest WithUri<TRequest>(string uri, TRequest request)
        {
            RequestMessage.RequestUri = new Uri(uri);
            return request;
        }

        public HttpRequest Build() => new(RequestMessage);

    }
}