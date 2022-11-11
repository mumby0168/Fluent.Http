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
        /// <param name="name">A friendly name for the step.</param>
        public FluentStep(
            Func<Task> step, 
            Func<Task>? postStep = null,
            string? name = null)
        {
            _step = step;
            _postStep = postStep;
            Name = name;
        }

        /// <summary>
        /// Run the asynchronous step.
        /// </summary>
        /// <returns></returns>
        public Task ExecuteAsync() => _step();

        public int SequenceNumber { get; set; }
        
        public string? Name { get; }

        /// <summary>
        /// Performs a post function to the asynchronous step.
        /// </summary>
        /// <returns></returns>
        public Task ValidateAsync() => _postStep?.Invoke() ?? Task.CompletedTask;
    }
}