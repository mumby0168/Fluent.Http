using Fluent.Http.Dog.Api.Integration.Tests.Factories;
using System;
using System.Net.Http;

namespace Fluent.Http.Dog.Api.Integration.Tests.Abstractions
{
    public abstract class DogApiIntegrationTest
    {
        protected DogApiIntegrationTest()
        {
            Factory = new TodoWebApplicationFactory();
            Client = Factory.CreateClient();
            ServiceProvider = Factory.Services;
        }

        protected IServiceProvider ServiceProvider { get; }

        protected HttpClient Client { get; }

        protected TodoWebApplicationFactory Factory { get; }
    }
}