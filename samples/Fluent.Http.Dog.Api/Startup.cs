using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Fluent.Http.Dog.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) =>
            services.AddCosmosRepository(o =>
                {
                    o.DatabaseId = "dogs-db";
                    o.ContainerId = "dogs";
                })
                .AddSwaggerGen()
                .AddMvc();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) =>
            app.UseSwagger()
                .UseSwaggerUI()
                .UseRouting()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapGet("/", async context =>
                    {
                        await context.Response.WriteAsync("Dog API");
                    });
                });
    }
}