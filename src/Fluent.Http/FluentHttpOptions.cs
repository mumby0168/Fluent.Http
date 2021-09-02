using Newtonsoft.Json;

namespace Fluent.Http
{
    public class FluentHttpOptions
    {

        public JsonSerializerSettings JsonSerializerSettings { get; set; } = new();

    }
}