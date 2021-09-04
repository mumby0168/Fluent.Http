using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fluent.Http
{
    public interface IFluentHttpClient
    {
        IFluentHttpClient Request(Func<HttpRequestMessage, Task> request, Func<HttpResponseMessage, Task> response);
        Task ExecuteAsync();
    }
}