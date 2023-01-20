namespace DreamHome.Infrastructure
{
    using DreamHome.Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices
             .GetRequiredService<IServiceScopeFactory>()
             .CreateScope())
            {
                using var context = serviceScope.ServiceProvider.GetService<DreamHomeDbContext>();
                context?.Database.Migrate();
            }

            return app;
        }
    }
}
