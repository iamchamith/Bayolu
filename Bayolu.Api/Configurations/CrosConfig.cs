using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Bayolu.Api.Configurations
{
    public static class CrosConfig
    {
        const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public static IServiceCollection ConfigureCrosServices(this IServiceCollection service)
        {
            service.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:5000")
                                      .AllowAnyOrigin()
                                      .AllowAnyHeader()
                                      .AllowAnyMethod();
                                  });
            });
            return service;
        }

        public static IApplicationBuilder ConfigureCros(this IApplicationBuilder app)
        {
            app.UseCors(MyAllowSpecificOrigins);
            return app;
        }
    }
}
