using System.Net.Http;

namespace Fluent.Http.Abstractions
{
    public class Response<TContext> where TContext : new()
    {
        public TContext Context { get; set; } = new();
        
        public HttpResponseMessage Message { get; set; } = new();
    }
}