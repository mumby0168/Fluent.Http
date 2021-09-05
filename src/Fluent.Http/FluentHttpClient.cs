
using Fluent.Http.Abstractions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fluent.Http
{
    /// <inheritdoc cref="IFluentHttpClient"/>
    public class FluentHttpClient : IFluentHttpClient
    {
        private readonly HttpClient _client;
        
        private FluentHttpClient(HttpClient? client) => _client = client ?? new HttpClient();

        public static IFluentHttpClient Build(HttpClient? client = null) =>
            new FluentHttpClient(client);

        /// <inheritdoc/>
        public List<IFluentStep> Steps { get; } = new();

        /// <inheritdoc/>
        public IFluentHttpClient Request(Func<Task<HttpRequestMessage>> request, Func<HttpResponseMessage, Task>? response = null)
        {
            Steps.Add(new FluentHttpStep(_client, request, response));
            return this;
        }

        /// <inheritdoc/>
        public IFluentHttpClient Request(Func<HttpRequestMessage> request, Func<HttpResponseMessage, Task>? response = null)
        {
            Steps.Add(new FluentHttpStep(_client, () => Task.FromResult(request()), response));
            return this;
        }

        /// <inheritdoc/>
        public IFluentHttpClient Step(Func<Task> step, Func<Task>? postStep = null)
        {
            Steps.Add(new FluentStep(step, postStep));
            return this;
        }
        
        /// <inheritdoc/>
        public async Task ExecuteAsync()
        {
            foreach (IFluentStep step in Steps)
            {
                await step.ExecuteAsync();

                if (step is IFluentValidationStep validationStep)
                {
                    await validationStep.ValidateAsync();
                }
            }
        }

    }
}