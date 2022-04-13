using AbstractStaticLanguagePreview.Models.Options;
using IBM.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;

namespace AbstractStaticLanguagePreview.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureOptions<T>(this IServiceCollection services, WebApplicationBuilder builder)
            where T : class, IOptions
        {
            return services.Configure<T>(builder.Configuration.GetSection(T.OptionsKey));
        }

        public static IServiceCollection ConfigureDbContext(this IServiceCollection services, AS400Options as400Options)
        {
            return services
                .AddDbContext<DbContext>(
                    options =>
                        options.UseDb2(
                            as400Options.ConnectionString,
                            o => o.SetServerInfo(IBMDBServerType.AS400)
                        )
                );
        }

        public static IServiceCollection ConfigureRedis(this IServiceCollection services, RedisOptions options)
        {
            var multiplexer = ConnectionMultiplexer.Connect(options.Configuration);
            return services.AddSingleton<IConnectionMultiplexer>(multiplexer);
        }

    }
}