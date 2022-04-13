using AbstractStaticLanguagePreview.Models.Options;

namespace AbstractStaticLanguagePreview.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        public static T GetOptions<T>(this WebApplicationBuilder builder) where T : IOptions 
            => builder.Configuration.GetSection(T.OptionsKey).Get<T>();
    }
}
