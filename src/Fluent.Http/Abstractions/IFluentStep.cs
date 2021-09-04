using System.Threading.Tasks;

namespace Fluent.Http.Abstractions
{
    public interface IFluentStep
    {
        Task ExecuteAsync();
    }
}