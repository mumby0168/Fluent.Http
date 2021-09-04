using Fluent.Http.Abstractions;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fluent.Http
{
    public class FluentHttpStep : IFluentValidationStep
    {
        private readonly HttpClient _client;
        private readonly Func<Task<HttpRequestMessage>> _messageFunc;
        private readonly Func<HttpResponseMessage, Task>? _responseFunc;
        private HttpResponseMessage _responseMessage = new();

        public FluentHttpStep(HttpClient client, Func<Task<HttpRequestMessage>> messageFunc, Func<HttpResponseMessage, Task>? responseFunc = null)
        {
            _client = client;
            _messageFunc = messageFunc;
            _responseFunc = responseFunc;
        }

        public async Task ExecuteAsync() => 
            _responseMessage = await _client.SendAsync(await _messageFunc.Invoke());

        public Task ValidateAsync() => 
            _responseFunc?.Invoke(_responseMessage) ?? Task.CompletedTask;
    }
}