namespace AbstractStaticLanguagePreview.Models.Options
{
    public class RedisOptions : IOptions
    {
        public static string OptionsKey => "Redis";

        public string Configuration { get; set; } = string.Empty;
    }
}
