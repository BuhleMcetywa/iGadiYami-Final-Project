namespace IGadiYami.Configuration
{
    public class Settings : ISettings
    {
        public string AzureSearchEndPoint { get => "https://loadsheddinglpsearch.search.windows.net"; }
        public string AzureSearchKey { get => "zfpzkNyNzrvST2yOOG6k7RV0n9Xm56Gj8IpNEt2a6RAzSeDgl7rd"; }
        public string AzureOpenAiEndPoint { get => "https://igadiyamiopenai.openai.azure.com/"; }
        public string AzureOpenAiKey { get => "2befb13109774d6a841fd33c510dd29e"; }
    }
}
