using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fluent.Http.Abstractions
{
    public interface IFluentHttpClient
    {
        /// <summary>
        /// A list of steps in the order they are to be executed
        /// <remarks>You can add your own steps via extension methods.</remarks>
        /// </summary>
        List<IFluentStep> Steps { get; }

        /// <summary>
        /// Adds a http step to the list of steps for this fluent http client
        /// </summary>
        /// <param name="request">A function that returns a <see cref="HttpRequestMessage"/> for this http request.</param>
        /// <param name="response">Performs work on the <see cref="HttpResponseMessage"/> after the http request has been made.</param>
        /// <param name="name">Friendly name to identify the step</param>
        /// <returns></returns>
        IFluentHttpClient Request(
            Func<Task<HttpRequestMessage>> request, 
            Func<HttpResponseMessage, Task>? response = null,
            string? name = null);
        
        /// <summary>
        /// Adds a http step to the list of steps for this fluent http client
        /// </summary>
        /// <param name="request">A function that returns a <see cref="HttpRequestMessage"/> for this http request.</param>
        /// <param name="response">Performs work on the <see cref="HttpResponseMessage"/> after the http request has been made.</param>
        /// /// <param name="name">Friendly name to identify the step</param>
        /// <returns></returns>
        IFluentHttpClient Request(
            Func<HttpRequestMessage> request, 
            Func<HttpResponseMessage, Task>? response = null,
            string? name = null);

        /// <summary>
        /// Adds step to the fluent client that does not have to be a http call.
        /// </summary>
        /// <param name="step">A asynchronous function to execute.</param>
        /// <param name="postStep">Some action to perform after the asynchronous function has run.</param>
        /// /// <param name="name">Friendly name to identify the step</param>
        /// <returns></returns>
        IFluentHttpClient Step(
            Func<Task> step, 
            Func<Task>? postStep = null,
            string? name = null);
        
        /// <summary>
        /// Executes all the steps defined in the <see cref="Steps"/>
        /// </summary>
        Task ExecuteAsync();
    }
}