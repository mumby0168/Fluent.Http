using FluentAssertions;
using RichardSzalay.MockHttp;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Fluent.Http.Tests
{
    public class FluentHttpStepTests
    {

        readonly MockHttpMessageHandler _handler = new();
        readonly HttpClient _client;

        public FluentHttpStepTests() => _client = _handler.ToHttpClient();

        [Fact]
        public async Task ExecuteAsync_HttpRequest_GetsHttpResponse()
        {
            _handler
                .When(HttpMethod.Get, "http://test.com/api/test")
                .Respond(HttpStatusCode.OK);

            FluentHttpStep step = new(_client, () => Task.FromResult(new HttpRequestMessage(HttpMethod.Get, "http://test.com/api/test")));

            await step.ExecuteAsync();

            step.ResponseMessage.Should().Be200Ok();
        }
    }
}