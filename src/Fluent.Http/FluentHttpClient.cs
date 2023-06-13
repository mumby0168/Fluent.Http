
using Fluent.Http.Abstractions;
using Fluent.Http.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fluent.Http
{
    /// <inheritdoc cref="IFluentHttpClient"/>
    public class FluentHttpClient : IFluentHttpClient
    {
        private readonly HttpClient _client;
        private Int32 _numberOfStepsExectued = 0;
        
        private FluentHttpClient(HttpClient? client) => _client = client ?? new HttpClient();

        public static IFluentHttpClient Build(HttpClient? client = null) =>
            new FluentHttpClient(client);

        /// <inheritdoc/>
        public List<IFluentStep> Steps { get; } = new();

        /// <inheritdoc/>
        public IFluentHttpClient Request(
            Func<Task<HttpRequestMessage>> request, 
            Func<HttpResponseMessage, Task>? response = null,
            string? name = null)
        {
            Steps.Add(new FluentHttpStep(
                _client, 
                request, 
                response,
                name));
            return this;
        }

        /// <inheritdoc/>
        public IFluentHttpClient Request(
            Func<HttpRequestMessage> request,
            Func<HttpResponseMessage, Task>? response = null,
            string? name = null)
        {
            Steps.Add(new FluentHttpStep(
                _client, 
                () => Task.FromResult(request()), 
                response, 
                name));
            return this;
        }

        /// <inheritdoc/>
        public IFluentHttpClient Step(
            Func<Task> step, 
            Func<Task>? postStep = null,
            string? name = null)
        {
            Steps.Add(new FluentStep(
                step, 
                postStep,
                name));
            return this;
        }
        
        /// <inheritdoc/>
        public async Task ExecuteAsync()
        {
            foreach (IFluentStep step in Steps.Skip(_numberOfStepsExectued))
            {
                Int32 stepSequenceNumber = _numberOfStepsExectued + 1;
                step.SequenceNumber = stepSequenceNumber;

                try
                {
                    await step.ExecuteAsync();
                }
                catch (Exception e)
                {
                    throw new FluentStepFailedException(stepSequenceNumber, step.Name, e);
                }

                if (step is IFluentValidationStep validationStep)
                {
                    try
                    {
                        await validationStep.ValidateAsync();
                    }
                    catch (Exception e)
                    {
                        throw new FluentStepValidationFailedException(stepSequenceNumber, step.Name, e);
                    }
                }
                
                _numberOfStepsExectued++;
            }
        }

        /// <inheritdoc/>
        public IFluentHttpClient Rewind(Int32? count = null)
        {
            count ??= _numberOfStepsExectued;
            _numberOfStepsExectued -= count.Value;

            if (_numberOfStepsExectued < 0)
            {
                _numberOfStepsExectued = 0;
            }
            
            return this;
        }
    }
}