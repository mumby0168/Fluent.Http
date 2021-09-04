# Fluent.Http
A library for executing a set of http operations in a sequence using a fluent API. This library is more suited towards writing integration/acceptance tests but could still be used where http calls need to be made in a specific order. In a lot of cases integration test's can become very large and methods can bloat quite easily. The idea of this library is to write test's as you would production code small little reusable snippets of code that have a clean and concise action to perform. `Fluent.Http` provides the foundations for this when talking about testing web api projects which are becoming more & more popular.

## Getting Started

In order to get started go and get the nuget package `Mumby0168.Fluent.Http` and install it into your desired project.

You can create an instance of the `IFluentHttpClient` by using the static builder method as shown below.
```c#
IFluentHttpClient fluentClient = FluentHttpClient.Build();
```

This also can optionally take an instance of a http client to include things such as default request headers & a base address.

```c#
HttpClient client = new HttpClient() { BaseAddress = new Uri("http://www.google.co.uk") };
IFluentHttpClient fluentClient = FluentHttpClient.Build();
```

Once you have created an instance of a client then a set of http requests can be chained together using the fluent API and then ran using the `ExecuteAsync()` method to run the requests in the order they have been defined. See below for a complete example.

> Not the first line in this sample make use of the new static using statement to trim down the code in the example below.

```c#
//excluding for brevity
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
    }
}
```

The main parts to note here are the `.Request(...)` methods which construct the `HttpRequestMessage` for that api call and also optionally process the `HttpResponseMessage`. These are defined by functions that are passed to the library and executing in the order they are defined.

The `HttpRequestMessageFactory` exposes a set of helper methods to get started with common request types such as Post, Put, Patch, Get and Delete. See the snippet below for the implementation of this class to see how it just simplifies the usage of the `HttpRequestMessageBuilder` class which can also be used to create `HttpRequestMessage`'s.

```c#
public static class HttpRequestMessageFactory
{
    public static HttpRequestMessageBuilder Post() => 
        new HttpRequestMessageBuilder().WithMethod(HttpMethod.Post);
    
    public static HttpRequestMessageBuilder Put() => 
        new HttpRequestMessageBuilder().WithMethod(HttpMethod.Put);
    
    public static HttpRequestMessageBuilder Get() => 
        new HttpRequestMessageBuilder().WithMethod(HttpMethod.Get);
    
    public static HttpRequestMessageBuilder Delete() => 
        new HttpRequestMessageBuilder().WithMethod(HttpMethod.Delete);

    public static HttpRequestMessageBuilder Patch() =>
        new HttpRequestMessageBuilder().WithMethod(FluentHttpConstants.HttpMethodPatch);
}
```

### Samples
The `/samples` directory contains a sample api and a set of integration test's to go with it which make use of the `Microsoft.AspNetCore.Mvc.Testing` nuget package (a great partner for `Fluent.Http`) to run integration test's in memory.
