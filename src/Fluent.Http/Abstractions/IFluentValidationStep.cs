using System.Threading.Tasks;

namespace Fluent.Http.Abstractions
{
    public interface IFluentValidationStep : IFluentStep
    {
        Task ValidateAsync();
    }
}