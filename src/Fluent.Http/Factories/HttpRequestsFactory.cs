using Fluent.Http.Requests;
using Newtonsoft.Json;

namespace Fluent.Http.Factories
{
    public static class HttpRequestsFactory
    {
        public static FluentHttpOptions Options { get; set; } = new();

        public static PostRequestBuilder Post() => new(Options);

    }
}