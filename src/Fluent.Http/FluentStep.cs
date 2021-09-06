using Fluent.Http.Abstractions;
using System;
using System.Threading.Tasks;

namespace Fluent.Http
{
    /// <summary>
    /// A simple step to be run by the <see cref="IFluentHttpClient"/>
    /// </summary>
    public class FluentStep : IFluentValidationStep
    {
        private readonly Func<Task> _step;
        private readonly Func<Task>? _postStep;

        /// <summary>
        /// Creates an instance of the <see cref="FluentStep"/>
        /// </summary>
        /// <param name="step">The asynchronous step to run.</param>
        /// <param name="postStep">The asynchronous post step to run.</param>
        public FluentStep(Func<Task> step, Func<Task>? postStep = null)
        {
            _step = step;
            _postStep = postStep;
        }

        /// <summary>
        /// Run the asynchronous step.
        /// </summary>
        /// <returns></returns>
        public Task ExecuteAsync() => _step();

        /// <summary>
        /// Performs a post function to the asynchronous step.
        /// </summary>
        /// <returns></returns>
        public Task ValidateAsync() => _postStep?.Invoke() ?? Task.CompletedTask;
    }
}