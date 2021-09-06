using Fluent.Http.Tests.Models;
using FluentAssertions;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace Fluent.Http.Tests
{
    public class HttpRequestMessageBuilderTests
    {
        [Fact]
        public async Task WithJsonBody_Object_SetsBody()
        {
            HttpRequestMessageBuilder builder = new();

            HttpRequestMessage message = builder
                .WithJsonBody(new Person {Id = 1, Name = "Joe Bloggs"});

            message.Content.Should().BeOfType<StringContent>();
            StringContent content = (StringContent)message.Content!;
            Person? person = await content.ReadFromJsonAsync<Person>();
            person!.Id.Should().Be(1);
            person.Name.Should().Be("Joe Bloggs");
        }
        
        [Fact]
        public void WithMethod_HttpMethod_SetsMethod()
        {
            HttpRequestMessageBuilder builder = new();

            HttpRequestMessage message = builder
                .WithMethod(HttpMethod.Post);

            message.Method.Should().Be(HttpMethod.Post);
        }
        
        [Fact]
        public void WithMethod_StringHttpMethod_SetsMethod()
        {
            HttpRequestMessageBuilder builder = new();

            HttpRequestMessage message = builder
                .WithMethod(FluentHttpConstants.HttpMethodPatch);

            message.Method.ToString().Should().Be("PATCH");
        }
        
        
        [Fact]
        public void WithUrl_Url_SetsRealativeUri()
        {
            HttpRequestMessageBuilder builder = new();

            HttpRequestMessage message = builder
                .WithUrl("api/test");

            message.RequestUri!.ToString().Should().Be("api/test");
        }
        
        [Fact]
        public void Build_Message_ReturnsMessage()
        {
            HttpRequestMessageBuilder builder = new();

            HttpRequestMessage message = builder
                .WithUrl("api/test").Build();

            message.RequestUri!.ToString().Should().Be("api/test");
        }
    }
}