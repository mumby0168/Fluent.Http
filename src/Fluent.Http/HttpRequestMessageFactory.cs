using Newtonsoft.Json;
using System.Diagnostics.Contracts;
using System.Net.Http;

namespace Fluent.Http
{
    /// <summary>
    /// A factory to easily create common requests.
    /// <remarks>using static Fluent.Http.HttpRequestMessageFactory; gives easy access to methods.</remarks>
    /// </summary>
    public static class HttpRequestMessageFactory
    {
        /// <summary>
        /// Creates a <see cref="HttpRequestMessageBuilder"/> for a http POST method.
        /// </summary>
        /// <returns><see cref="HttpRequestMessageBuilder"/></returns>
        public static HttpRequestMessageBuilder Post() => 
            new HttpRequestMessageBuilder().WithMethod(HttpMethod.Post);
        
        /// <summary>
        /// Creates a <see cref="HttpRequestMessageBuilder"/> for a http PUT method.
        /// </summary>
        /// <returns><see cref="HttpRequestMessageBuilder"/></returns>
        public static HttpRequestMessageBuilder Put() => 
            new HttpRequestMessageBuilder().WithMethod(HttpMethod.Put);
        
        /// <summary>
        /// Creates a <see cref="HttpRequestMessageBuilder"/> for a http GET method.
        /// </summary>
        /// <returns><see cref="HttpRequestMessageBuilder"/></returns>
        public static HttpRequestMessageBuilder Get() => 
            new HttpRequestMessageBuilder().WithMethod(HttpMethod.Get);
        
        /// <summary>
        /// Creates a <see cref="HttpRequestMessageBuilder"/> for a http DELETE method.
        /// </summary>
        /// <returns><see cref="HttpRequestMessageBuilder"/></returns>
        public static HttpRequestMessageBuilder Delete() => 
            new HttpRequestMessageBuilder().WithMethod(HttpMethod.Delete);

        /// <summary>
        /// Creates a <see cref="HttpRequestMessageBuilder"/> for a http PATCH method.
        /// </summary>
        /// <returns><see cref="HttpRequestMessageBuilder"/></returns>
        public static HttpRequestMessageBuilder Patch() =>
            new HttpRequestMessageBuilder().WithMethod(FluentHttpConstants.HttpMethodPatch);
        
        /// <summary>
        /// Creates a <see cref="HttpRequestMessageBuilder"/> for a http POST method.
        /// </summary>
        /// <param name="body">The body to serialized into the POST request</param>
        /// <param name="settings">The settings to be used by <see cref="JsonConvert"/></param>
        /// <typeparam name="TBody">The type of the body to be serialized.</typeparam>
        /// <returns><see cref="HttpRequestMessageBuilder"/></returns>
        public static HttpRequestMessageBuilder Post<TBody>(TBody body, JsonSerializerSettings? settings = null) => 
            new HttpRequestMessageBuilder()
                .WithMethod(HttpMethod.Post)
                .WithJsonBody(body, settings);
        
        /// <summary>
        /// Creates a <see cref="HttpRequestMessageBuilder"/> for a http PUT method.
        /// </summary>
        /// <param name="body">The body to serialized into the PUT request</param>
        /// <param name="settings">The settings to be used by <see cref="JsonConvert"/></param>
        /// <typeparam name="TBody">The type of the body to be serialized.</typeparam>
        /// <returns><see cref="HttpRequestMessageBuilder"/></returns>
        public static HttpRequestMessageBuilder Put<TBody>(TBody body, JsonSerializerSettings? settings = null) => 
            new HttpRequestMessageBuilder()
                .WithMethod(HttpMethod.Put)
                .WithJsonBody(body, settings);

        /// <summary>
        /// Creates a <see cref="HttpRequestMessageBuilder"/> for a http PATCH method.
        /// </summary>
        /// <param name="body">The body to serialized into the PATCH request</param>
        /// <param name="settings">The settings to be used by <see cref="JsonConvert"/></param>
        /// <typeparam name="TBody">The type of the body to be serialized.</typeparam>
        /// <returns><see cref="HttpRequestMessageBuilder"/></returns>
        public static HttpRequestMessageBuilder Patch<TBody>(TBody body, JsonSerializerSettings? settings = null) => 
            new HttpRequestMessageBuilder()
                .WithMethod(FluentHttpConstants.HttpMethodPatch)
                .WithJsonBody(body, settings);
    }
}