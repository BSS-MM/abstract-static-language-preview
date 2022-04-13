namespace AbstractStaticLanguagePreview.Models.Options
{
    public class NexiOptions : IOptions
    {
        public static string OptionsKey => "Nexi";

        public string MerchantId { get; set; } = string.Empty;
        public string MerchantPassword { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;

    }
}
