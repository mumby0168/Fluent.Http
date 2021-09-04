using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fluent.Http.Abstractions
{
    public interface IFluentHttpClient
    {
        List<IFluentStep> Steps { get; }
        
        IFluentHttpClient Request(Func<Task<HttpRequestMessage>> request, Func<HttpResponseMessage, Task>? response = null);
        
        IFluentHttpClient Request(Func<HttpRequestMessage> request, Func<HttpResponseMessage, Task>? response = null);

        IFluentHttpClient Step(Func<Task> step, Func<Task>? postStep = null);
        Task ExecuteAsync();
    }
}