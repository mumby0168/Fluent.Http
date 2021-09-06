using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Fluent.Http.Tests
{
    public class FluentStepTests
    {

        [Fact]
        public async Task ExecuteAsync_Step_Runs()
        {
            string setMe = string.Empty;
            FluentStep step = new(() =>
            {
                setMe = "test";
                return Task.CompletedTask;
            });

            await step.ExecuteAsync();

            setMe.Should().Be("test");
        }
        
        [Fact]
        public async Task ValidateAsync_PostStep_Runs()
        {
            string setMe = string.Empty;
            FluentStep step = new(() => Task.CompletedTask, () =>
            {
                setMe = "test1";
                return Task.CompletedTask;
            });

            await step.ValidateAsync();

            setMe.Should().Be("test1");
        }
        
        [Fact]
        public async Task ValidateAsync_NullPostStep_RunsWithNoError()
        {
            FluentStep step = new(() => Task.CompletedTask,null);

            await step.ValidateAsync();
        }
        
        

    }
}