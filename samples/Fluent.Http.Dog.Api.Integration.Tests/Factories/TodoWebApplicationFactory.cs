using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Fluent.Http.Dog.Api.Integration.Tests.Factories
{
    public class TodoWebApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureTestServices(services =>
            {
                services.RemoveCosmosRepositories();
                services.AddInMemoryCosmosRepository();
            });
            base.ConfigureWebHost(builder);
        }
    }
}