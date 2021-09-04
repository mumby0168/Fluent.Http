using Fluent.Http.Abstractions;
using Fluent.Http.Dog.Api.Integration.Tests.Abstractions;
using Fluent.Http.Dog.Api.Models;
using System.Threading.Tasks;
using Xunit;

namespace Fluent.Http.Dog.Api.Integration.Tests
{
    public class DogApiTests : DogApiIntegrationTest
    {
        [Fact]
        public async Task CreateDogThenTryAndCreateAnotherWithSameNameBreadShouldReturnBadRequest()
        {
            DogModel dog = new() {Breed = "Cocker", Name = "Dasher", Age = 12};
            
            IFluentHttpClient httpClient = FluentHttpClient.Build(Client);
            await Task.CompletedTask;
        }
    }
}