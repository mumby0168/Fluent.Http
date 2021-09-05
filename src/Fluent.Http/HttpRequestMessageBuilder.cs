using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace Fluent.Http
{
    /// <summary>
    /// A builder used to create a <see cref="HttpRequestMessage"/>
    /// </summary>
    public class HttpRequestMessageBuilder
    {
        /// <summary>
        /// The <see cref="HttpRequestMessage"/> being built.
        /// </summary>
        public HttpRequestMessage Message { get; } = new();

        /// <summary>
        /// Sets the RequestUri on the <see cref="HttpRequestMessage"/>.
        /// </summary>
        /// <param name="url"></param>
        /// <returns>The <see cref="HttpRequestMessageBuilder"/> builder for the current message.</returns>
        public HttpRequestMessageBuilder WithUrl(string url)
        {
            Message.RequestUri = new Uri(url, UriKind.Relative);
            return this;
        }

        /// <summary>
        /// Serializes the body provided into json and assigns the Content of the <see cref="HttpRequestMessage"/> as <see cref="StreamContent"/>
        /// </summary>
        /// <param name="body">The object to be serialized to json.</param>
        /// <param name="jsonSerializerSettings">The settings to be used by <see cref="JsonConvert"/></param>
        /// <typeparam name="TBody">The type of the object to be serialized.</typeparam>
        /// <returns></returns>
        public HttpRequestMessageBuilder WithJsonBody<TBody>(TBody body, JsonSerializerSettings? jsonSerializerSettings = null)
        {
            Message.Content = new StringContent(JsonConvert.SerializeObject(body, jsonSerializerSettings), Encoding.UTF8, FluentHttpConstants.ApplicationJson);
            return this;
        }

        /// <summary>
        /// Set the <see cref="HttpMethod"/> on the <see cref="HttpRequestMessage"/>
        /// </summary>
        /// <param name="method">The <see cref="HttpMethod"/> to set.</param>
        /// <returns></returns>
        public HttpRequestMessageBuilder WithMethod(HttpMethod method)
        {
            Message.Method = method;
            return this;
        }

        /// <summary>
        /// Set the <see cref="HttpMethod"/> on the <see cref="HttpRequestMessage"/>
        /// </summary>
        /// <param name="method">A string to set as the Method.</param>
        /// <returns></returns>
        public HttpRequestMessageBuilder WithMethod(string method)
        {
            Message.Method = new HttpMethod(method.ToUpper());
            return this;
        }

        /// <summary>
        /// Builds the HttpRequestMessage
        /// </summary>
        /// <returns><see cref="Message"/></returns>
        public HttpRequestMessage Build() 
            => Message;

        public static implicit operator HttpRequestMessage(HttpRequestMessageBuilder builder) => 
            builder.Message;
    }
}