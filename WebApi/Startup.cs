using Serilog;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Register the Swagger generator, defining 1 or more Swagger documents
            // Based on https://petstore.swagger.io/v2/swagger.json
            services.AddSwaggerGen(c => {
                // v1 appears to used for SwaggerEndpoint: /swagger/{name}/swagger.json
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Description = "This is a sample server Petstore server.  You can find out more about " +
                    "Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger]" +
                    "(http://swagger.io/irc/).  For this sample, you can use the api key `special-key` to" +
                    " test the authorization filters.",
                    Version = "1.0.5",
                    Title = "Swagger Petstore",
                    TermsOfService = new Uri("http://swagger.io/terms/"),
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Email = "apiteam@swagger.io"
                    },
                    License = new Microsoft.OpenApi.Models.OpenApiLicense
                    {
                        Name = "Apache 2.0",
                        Url = new Uri("http://www.apache.org/licenses/LICENSE-2.0.html")
                    }
                    // TODO missing externalDocs
                    // TODO missing host (or Base URL)
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // "The middleware will not time or log components that appear before it in the pipeline"
            app.UseSerilogRequestLogging();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui(HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Petstore");
                // To serve the Swagger UI at the app's root (http://localhost:<port>/), set the
                // RoutePrefix property to an empty string:
                c.RoutePrefix = string.Empty;
            });
            // TODO consider how to load swagger.json from static file

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
