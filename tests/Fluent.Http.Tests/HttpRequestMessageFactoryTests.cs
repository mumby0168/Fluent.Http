using Fluent.Http.Tests.Models;
using FluentAssertions;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;
using static Fluent.Http.HttpRequestMessageFactory;


namespace Fluent.Http.Tests
{
    public class HttpRequestMessageFactoryTests
    {
        [Fact]
        public void Post___ReturnsPostMessage() => 
            Post().Message.Method.Should().Be(HttpMethod.Post);
        
        [Fact]
        public void Get___ReturnsGetMessage() => 
            Get().Message.Method.Should().Be(HttpMethod.Get);
        
        [Fact]
        public void Put___ReturnsPutMessage() => 
            Put().Message.Method.Should().Be(HttpMethod.Put);
        
        [Fact]
        public void Delete___ReturnsDeleteMessage() => 
            Delete().Message.Method.Should().Be(HttpMethod.Delete);
        
        [Fact]
        public void Patch___ReturnsPatchMessage() => 
            Patch().Message.Method.ToString().Should().Be(FluentHttpConstants.HttpMethodPatch);
        
        
        [Fact]
        public async Task Post_JsonObject_SetsPostRequestCorrectly()
        {
            HttpRequestMessage message = Post(new Person {Id = 1, Name = "Joe Bloggs"});

            message.Content.Should().BeOfType<StringContent>();
            message.Method.Should().Be(HttpMethod.Post);
            var content = (StringContent)message.Content!;
            Person? person = await content.ReadFromJsonAsync<Person>();
            person!.Id.Should().Be(1);
            person.Name.Should().Be("Joe Bloggs");
        }
        
        [Fact]
        public async Task Put_JsonObject_SetsPutRequestCorrectly()
        {
            HttpRequestMessage message = Put(new Person {Id = 1, Name = "Joe Bloggs"});

            message.Content.Should().BeOfType<StringContent>();
            message.Method.Should().Be(HttpMethod.Put);
            var content = (StringContent)message.Content!;
            Person? person = await content.ReadFromJsonAsync<Person>();
            person!.Id.Should().Be(1);
            person.Name.Should().Be("Joe Bloggs");
        }
        
        [Fact]
        public async Task Patch_JsonObject_SetsPatchRequestCorrectly()
        {
            HttpRequestMessage message = Put(new Person {Id = 1, Name = "Joe Bloggs"});

            message.Content.Should().BeOfType<StringContent>();
            message.Method.Should().Be(HttpMethod.Patch);
            var content = (StringContent)message.Content!;
            Person? person = await content.ReadFromJsonAsync<Person>();
            person!.Id.Should().Be(1);
            person.Name.Should().Be("Joe Bloggs");
        }

    }
}