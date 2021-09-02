using Fluent.Http.Abstractions;
using Fluent.Http.Factories;
using Fluent.Http.Requests;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fluent.Http
{
    public class FluentHttpClient<TContext> : IFluentHttpClient<TContext> where TContext : class, new()
    {

        private readonly HttpClient? _client;


        private FluentHttpClient(HttpClient? client) => _client = client;

        public static IFluentHttpClient<TContext> Build(HttpClient? client = null, FluentHttpOptions? options = null)
        {
            HttpRequestsFactory.Options = options ?? new();
            return new FluentHttpClient<TContext>(client);
        }

        public IFluentHttpClient<TContext> Post(Func<PostRequestBuilder, HttpRequest> requestBuilder, Action<Response<TContext>>? responseValidator = null) => throw new NotImplementedException();

        public IFluentHttpClient<TContext> Post(Func<TContext, PostRequestBuilder, HttpRequest> requestBuilder, Action<Response<TContext>>? responseValidator = null) => throw new NotImplementedException();

        public IFluentHttpClient<TContext> Request(HttpRequest requestBuilder, Action<Response<TContext>>? responseValidator = null) => throw new NotImplementedException();

        public IFluentHttpClient<TContext> Request(Func<TContext, HttpRequest> requestBuilder, Action<Response<TContext>>? responseValidator = null) => throw new NotImplementedException();

        public Task ExecuteAsync() => throw new NotImplementedException();

    }
}