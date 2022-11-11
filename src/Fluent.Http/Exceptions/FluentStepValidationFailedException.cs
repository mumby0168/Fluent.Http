using System;

namespace Fluent.Http.Exceptions;

/// <summary>
/// States that a step failed to execute
/// </summary>
public class FluentStepValidationFailedException : Exception
{
    public int Step { get; }
    public string? Name { get; }

    public FluentStepValidationFailedException(
        int step,
        string? name,
        Exception innerException) :
        base($"The step at position {step} ({name ?? "undefined"}) failed validation with exception {innerException}",
            innerException)
    {
        Step = step;
        Name = name;
    }
}