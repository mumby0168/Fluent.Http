using Fluent.Http.Abstractions;
using Fluent.Http.Dog.Api.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fluent.Http.Dog.Api.Integration.Tests.Extensions
{
    public static class DogApiExtensions
    {
        public static IFluentHttpClient CreateDog(this IFluentHttpClient client, Func<DogModel> dog, Func<HttpResponseMessage, Task>? response = null) => 
            client.Request(() => HttpRequestMessageFactory.Post(dog()).WithUrl("api/dog"), response);

        public static IFluentHttpClient IncrementDogsAge(this IFluentHttpClient client, Func<DogModel> dog, Func<HttpResponseMessage, Task>? response = null) =>
            client.Request(() =>
            {
                DogModel d = dog();
                d.Age++;
                return HttpRequestMessageFactory.Put(d).WithUrl("api/dog");
            }, response);

        public static IFluentHttpClient GetDog(this IFluentHttpClient client, Func<string> id, Func<HttpResponseMessage, Task>? response = null) =>
            client.Request(() => HttpRequestMessageFactory.Get().WithUrl($"api/dog/{id()}"), response);

        public static IFluentHttpClient DeleteDog(this IFluentHttpClient client, Func<string> id, Func<HttpResponseMessage, Task>? response = null) =>
            client.Request(() => HttpRequestMessageFactory.Delete().WithUrl($"api/dog/{id()}"), response);

        public static IFluentHttpClient GetDogs(this IFluentHttpClient client, Func<HttpResponseMessage, Task>? response = null) =>
            client.Request(() => HttpRequestMessageFactory.Get().WithUrl("api/dog"), response);
    }
}