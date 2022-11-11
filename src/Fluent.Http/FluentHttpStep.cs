using Fluent.Http.Abstractions;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fluent.Http
{
    /// <summary>
    /// A step to be run by the <see cref="IFluentHttpClient"/> to make http requests
    /// </summary>
    public class FluentHttpStep : IFluentValidationStep
    {
        private readonly HttpClient _client;
        private readonly Func<Task<HttpRequestMessage>> _messageFunc;
        private readonly Func<HttpResponseMessage, Task>? _responseFunc;
        internal HttpResponseMessage ResponseMessage = new();

        /// <summary>
        /// Creates an instance of the <see cref="FluentHttpStep"/>
        /// </summary>
        /// <param name="client">The http client to use for the request.</param>
        /// <param name="messageFunc">A function which returns the <see cref="HttpRequestMessage"/> to send.</param>
        /// <param name="responseFunc">A function which handles the <see cref="HttpResponseMessage"/> returned.</param>
        /// <param name="name">A friendly name for the step.</param>
        public FluentHttpStep(
            HttpClient client, 
            Func<Task<HttpRequestMessage>> messageFunc, 
            Func<HttpResponseMessage, Task>? responseFunc = null,
            string? name = null)
        {
            _client = client;
            _messageFunc = messageFunc;
            _responseFunc = responseFunc;
            Name = name;
        }

        /// <summary>
        /// Executes the <see cref="HttpRequestMessage"/>.
        /// </summary>
        public async Task ExecuteAsync() => 
            ResponseMessage = await _client.SendAsync(await _messageFunc.Invoke());

        public int SequenceNumber { get; set; }
        public string? Name { get; }

        /// <summary>
        /// Processes the <see cref="HttpResponseMessage"/>
        /// </summary>
        /// <returns></returns>
        public Task ValidateAsync() => 
            _responseFunc?.Invoke(ResponseMessage) ?? Task.CompletedTask;
    }
}