using Jezoori.Mapping;
using Scrutor;

namespace Jezoori.Extensions
{
    public static class ServiceCollectionInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {


            services.AddHttpClient();
            services.Scan(scan => scan

               .FromApplicationDependencies(a => a.ManifestModule.Name != "PremiumMainCS.dll")

               .AddClasses(classes => classes.InNamespaces(new[] {
                "Base",
                "Repository",
                             }))

               .UsingRegistrationStrategy(RegistrationStrategy.Skip)

               .AsSelfWithInterfaces()

               .WithScopedLifetime()

           );


        }


        public static void AddCorsConfig(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: "corspolicy",
                                  policy => { policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); });
            });

        }
        public static void AddMappingService(this IServiceCollection service)
        {

            service.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
