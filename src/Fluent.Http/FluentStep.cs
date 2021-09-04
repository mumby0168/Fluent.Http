using Fluent.Http.Abstractions;
using System;
using System.Threading.Tasks;

namespace Fluent.Http
{
    public class FluentStep : IFluentValidationStep
    {
        private readonly Func<Task> _step;
        private readonly Func<Task>? _postStep;

        public FluentStep(Func<Task> step, Func<Task>? postStep)
        {
            _step = step;
            _postStep = postStep;
        }

        public Task ExecuteAsync() => _step();

        public Task ValidateAsync() => _postStep?.Invoke() ?? Task.CompletedTask;
    }
}