namespace AbstractStaticLanguagePreview.Models.Options
{
    public class AS400Options : IOptions
    {
        public static string OptionsKey => "AS400";

        public string ConnectionString { get; set; } = string.Empty;
    }
}
