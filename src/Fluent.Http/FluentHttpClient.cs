
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fluent.Http
{
    public class FluentHttpClient : IFluentHttpClient
    {
        private readonly HttpClient? _client;
        
        private FluentHttpClient(HttpClient? client) => _client = client ?? new HttpClient();

        public static IFluentHttpClient Build(HttpClient? client = null) =>
            new FluentHttpClient(client);

        public IFluentHttpClient Request(Func<HttpRequestMessage, Task> request, Func<HttpResponseMessage, Task> response) => throw new NotImplementedException();

        public Task ExecuteAsync() => throw new NotImplementedException();

    }
}