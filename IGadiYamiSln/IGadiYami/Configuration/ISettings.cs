namespace IGadiYami.Configuration
{
    public interface ISettings
    {
        public string AzureSearchEndPoint { get; }
        public string AzureSearchKey { get; }
        public string AzureOpenAiEndPoint { get; }
        public string AzureOpenAiKey { get; }

    }
}
