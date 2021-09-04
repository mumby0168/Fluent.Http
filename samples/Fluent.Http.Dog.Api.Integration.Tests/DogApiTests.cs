using Fluent.Http.Dog.Api.Integration.Tests.Abstractions;
using Fluent.Http.Dog.Api.Integration.Tests.Extensions;
using Fluent.Http.Dog.Api.Models;
using FluentAssertions;
using Microsoft.Azure.CosmosRepository;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;
using static Fluent.Http.HttpRequestMessageFactory;

namespace Fluent.Http.Dog.Api.Integration.Tests
{
    public class DogApiTests : DogApiIntegrationTest
    {
        private readonly IRepository<DogModel> _dogRepository;

        public DogApiTests() => _dogRepository = ServiceProvider.GetRequiredService<IRepository<DogModel>>();

        [Fact]
        public async Task CreateDogThenTryAndCreateAnotherWithSameNameBreadShouldReturnBadRequestUsingRawApi()
        {
            DogModel dog = new() {Breed = "Cocker", Name = "Dasher", Age = 12};

            await FluentHttpClient.Build(Client)
                .Request(() => Post(dog).WithUrl("api/dog"), async response =>
                {
                    response.Should().Be200Ok();
                    DogModel? responseDog = await response.Content.ReadFromJsonAsync<DogModel>();
                    
                    responseDog.Should().NotBeNull();
                    responseDog!.Name.Should().Be(dog.Name);
                    responseDog.Age.Should().Be(dog.Age);
                    responseDog.Breed.Should().Be(dog.Breed);

                    DogModel dbDog = await _dogRepository.GetAsync(responseDog.Id);

                    dbDog.Name.Should().Be(dog.Name);
                    dbDog.Age.Should().Be(dog.Age);
                    dbDog.Breed.Should().Be(dog.Breed);

                })
                .Request(() => Post(dog).WithUrl("api/dog"), async response =>
                {
                    response.Should().Be400BadRequest();
                    string content = await response.Content.ReadAsStringAsync();
                    content.Should().Contain("already been assigned");
                })
                .ExecuteAsync();
        }

        [Fact]
        public async Task ExerciseApiCreateReadUpdateReadAgainThenDeleteADogThenEnsureNoDogs()
        {
            DogModel dog = new() {Breed = "Cocker", Name = "Dasher", Age = 12};

            string dogId = string.Empty;

            await FluentHttpClient.Build(Client)
                .CreateDog(() => dog, async response =>
                {
                    response.Should().Be200Ok();
                    DogModel? responseDog = await response.Content.ReadFromJsonAsync<DogModel>();
                    dogId = responseDog!.Id;
                })
                .GetDog(() => dogId, async response =>
                {
                    response.Should().Be200Ok();
                    DogModel? responseDog = await response.Content.ReadFromJsonAsync<DogModel>();
                    responseDog!.Age.Should().Be(dog.Age);
                    responseDog.Breed.Should().Be(dog.Breed);
                    responseDog.Name.Should().Be(dog.Name);
                })
                .GetDogs(async response =>
                {
                    response.Should().Be200Ok();
                    List<DogModel>? dogs = await response.Content.ReadFromJsonAsync<List<DogModel>>();
                    dogs!.Count().Should().Be(1);
                })
                .IncrementDogsAge(() => dog, respone =>
                {
                    respone.Should().Be200Ok();
                    return Task.CompletedTask;
                })
                .GetDog(() => dogId, async response =>
                {
                    response.Should().Be200Ok();
                    DogModel? responseDog = await response.Content.ReadFromJsonAsync<DogModel>();
                    responseDog!.Age.Should().Be(13);
                })
                .DeleteDog(() => dogId)
                .GetDogs(async response =>
                {
                    List<DogModel>? dogs = await response.Content.ReadFromJsonAsync<List<DogModel>>();
                    dogs!.Count().Should().Be(0);
                })
                .ExecuteAsync();
        }
    }
}