using System.Threading.Tasks;

namespace Fluent.Http.Abstractions
{
    /// <summary>
    /// A step that has an execute method and a method to perform as validation for the first call.
    /// </summary>
    public interface IFluentValidationStep : IFluentStep
    {
        /// <summary>
        /// A function called after the ExecuteAsync method.
        /// </summary>
        /// <returns></returns>
        Task ValidateAsync();
    }
}