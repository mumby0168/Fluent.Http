using Newtonsoft.Json;
using System.Diagnostics.Contracts;
using System.Net.Http;

namespace Fluent.Http
{
    public static class HttpRequestMessageFactory
    {
        public static HttpRequestMessageBuilder Post() => 
            new HttpRequestMessageBuilder().WithMethod(HttpMethod.Post);
        
        public static HttpRequestMessageBuilder Post<TBody>(TBody body, JsonSerializerSettings? settings = null) => 
            new HttpRequestMessageBuilder()
                .WithMethod(HttpMethod.Post)
                .WithJsonBody(body, settings);
        
        public static HttpRequestMessageBuilder Put<TBody>(TBody body, JsonSerializerSettings? settings = null) => 
            new HttpRequestMessageBuilder()
                .WithMethod(HttpMethod.Put)
                .WithJsonBody(body, settings);
        
        public static HttpRequestMessageBuilder Put() => 
            new HttpRequestMessageBuilder().WithMethod(HttpMethod.Put);
        
        public static HttpRequestMessageBuilder Get() => 
            new HttpRequestMessageBuilder().WithMethod(HttpMethod.Get);
        
        public static HttpRequestMessageBuilder Delete() => 
            new HttpRequestMessageBuilder().WithMethod(HttpMethod.Delete);

        public static HttpRequestMessageBuilder Patch() =>
            new HttpRequestMessageBuilder().WithMethod(FluentHttpConstants.HttpMethodPatch);
    }
}