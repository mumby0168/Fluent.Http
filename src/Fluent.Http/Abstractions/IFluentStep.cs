using System.Threading.Tasks;

namespace Fluent.Http.Abstractions
{
    /// <summary>
    /// A fluent step that can be run by the <see cref="IFluentHttpClient"/>
    /// </summary>
    public interface IFluentStep
    {
        /// <summary>
        /// What code the step should run.
        /// </summary>
        /// <returns></returns>
        Task ExecuteAsync();
        
        /// <summary>
        /// The sequence number relative to all steps in the chain
        /// </summary>
        int SequenceNumber { get; set; }
        
        /// <summary>
        /// A friendly name for a given step
        /// </summary>
        string? Name { get; }
    }
}