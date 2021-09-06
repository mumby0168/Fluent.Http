using Fluent.Http.Abstractions;
using FluentAssertions;
using RichardSzalay.MockHttp;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Fluent.Http.Tests
{
    public class FluentHttpClientTests
    {
        readonly MockHttpMessageHandler _handler = new();
        readonly HttpClient _client;

        public FluentHttpClientTests()
        {
            _client = _handler.ToHttpClient();
            _client.BaseAddress = new Uri("http://test.com/");
        }

        [Fact]
        public async Task ExecuteAsync_AsyncHttpRequest_RunsCorrectly()
        {
            _handler
                .When(HttpMethod.Get, "http://test.com/api/test")
                .Respond(HttpStatusCode.OK);

            bool calledMessage = false;
            bool calledValidate = false;
            
            IFluentHttpClient client = FluentHttpClient.Build(_client);

            await client.Request(
                    () =>
                    {
                        calledMessage = true;
                        calledValidate.Should().BeFalse();
                        return Task.FromResult(HttpRequestMessageFactory.Get().WithUrl("api/test").Build());
                    },
                    message =>
                    {
                        calledMessage.Should().BeTrue();
                        calledValidate = true;
                        message.Should().Be200Ok();
                        return Task.CompletedTask;
                    })
                .ExecuteAsync();

            calledMessage.Should().BeTrue();
            calledValidate.Should().BeTrue();
        }
        
        [Fact]
        public async Task ExecuteAsync_HttpRequest_RunsCorrectly()
        {
            _handler
                .When(HttpMethod.Get, "http://test.com/api/test")
                .Respond(HttpStatusCode.OK);

            bool calledMessage = false;
            bool calledValidate = false;
            
            IFluentHttpClient client = FluentHttpClient.Build(_client);

            await client.Request(
                    () =>
                    {
                        calledMessage = true;
                        calledValidate.Should().BeFalse();
                        return HttpRequestMessageFactory.Get().WithUrl("api/test").Build();
                    },
                    message =>
                    {
                        calledMessage.Should().BeTrue();
                        calledValidate = true;
                        message.Should().Be200Ok();
                        return Task.CompletedTask;
                    })
                .ExecuteAsync();

            calledMessage.Should().BeTrue();
            calledValidate.Should().BeTrue();
        }
        
        [Fact]
        public async Task ExecuteAsync_SimpleStep_RunsCorrectly()
        {
            _handler
                .When(HttpMethod.Get, "http://test.com/api/test")
                .Respond(HttpStatusCode.OK);

            bool calledStep = false;
            bool calledPostStep = false;
            
            IFluentHttpClient client = FluentHttpClient.Build(_client);

            await client.Step(
                    () =>
                    {
                        calledStep = true;
                        calledPostStep.Should().BeFalse();
                        return Task.CompletedTask;
                    },
                    () =>
                    {
                        calledStep.Should().BeTrue();
                        calledPostStep = true;
                        return Task.CompletedTask;
                    })
                .ExecuteAsync();

            calledStep.Should().BeTrue();
            calledPostStep.Should().BeTrue();
        }
    }
}