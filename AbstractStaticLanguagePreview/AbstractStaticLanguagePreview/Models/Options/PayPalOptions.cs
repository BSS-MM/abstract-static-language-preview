namespace AbstractStaticLanguagePreview.Models.Options
{
    public class PayPalOptions : IOptions
    {
        public static string OptionsKey => "PayPal";

        public string ClientId { get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
        public string BaseUrl { get; set; } = string.Empty;
        public string CreateOrderRelativeUrl { get; set; } = string.Empty;
        public string AuthorizeOrderRelativeUrl { get; set; } = string.Empty;
        public string CaptureOrderRelativeUrl { get; set; } = string.Empty;
    }
}
