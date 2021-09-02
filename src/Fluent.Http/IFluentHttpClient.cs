using Fluent.Http.Abstractions;
using Fluent.Http.Requests;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fluent.Http
{
    public interface IFluentHttpClient<TContext> where TContext : class, new()
    {
        
        IFluentHttpClient<TContext> Post(Func<PostRequestBuilder, HttpRequest> requestBuilder, Action<Response<TContext>>? responseValidator = null);   

        IFluentHttpClient<TContext> Post(Func<TContext, PostRequestBuilder, HttpRequest> requestBuilder, Action<Response<TContext>>? responseValidator = null);
    
        IFluentHttpClient<TContext> Request(HttpRequest requestBuilder, Action<Response<TContext>>? responseValidator = null);
        
        IFluentHttpClient<TContext> Request(Func<TContext, HttpRequest> requestBuilder, Action<Response<TContext>>? responseValidator = null);    

        Task ExecuteAsync();
    }
}