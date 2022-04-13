namespace AbstractStaticLanguagePreview.Models.Options

{
    public interface IOptions
    {
        public abstract static string OptionsKey { get; }
    }
}

// https://devblogs.microsoft.com/dotnet/early-peek-at-csharp-11-features/
// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/static-abstract-interface-methods