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
        
        [Fact]
        public async Task ExecuteAsync_MultipleCalls_DoesNotExecuteStepsTwice()
        {
            _handler
                .When(HttpMethod.Get, "http://test.com/api/test")
                .Respond(HttpStatusCode.OK);

            int stepOneCallCount = 0;
            int stepTwoCallCount = 0;
            
            IFluentHttpClient client = FluentHttpClient.Build(_client);

            await client.Step(
                    () =>
                    {
                        stepOneCallCount++;
                        return Task.CompletedTask;
                    })
                .ExecuteAsync();

            await client.Step(
                    () =>
                    {
                        stepTwoCallCount++;
                        return Task.CompletedTask;
                    })
                .ExecuteAsync();
            
            stepOneCallCount.Should().Be(1);
            stepTwoCallCount.Should().Be(1);
        }
        
        [Fact]
        public async Task ExecuteAsync_WithRewind_AllowsMultipleCalls()
        {
            _handler
                .When(HttpMethod.Get, "http://test.com/api/test")
                .Respond(HttpStatusCode.OK);

            int stepOneCallCount = 0;
            int stepTwoCallCount = 0;
            
            IFluentHttpClient client = FluentHttpClient.Build(_client);

            await client.Step(
                    () =>
                    {
                        stepOneCallCount++;
                        return Task.CompletedTask;
                    })
                .ExecuteAsync();

            await client.Step(
                    () =>
                    {
                        stepTwoCallCount++;
                        return Task.CompletedTask;
                    })
                .ExecuteAsync();
            
            await client
                .Rewind(1)
                .ExecuteAsync();
            
            await client
                .Rewind()
                .ExecuteAsync();
            
            stepOneCallCount.Should().Be(2);
            stepTwoCallCount.Should().Be(3);
        }
    }
}