using Azure;
using Azure.AI.OpenAI;
using IGadiYami.Configuration;
using IGadiYami.Interface;
using IGadiYami.Models.ChatbotFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Services
{
    public class IgadiYamiAiAssistant : IAiAssistant
    {
        private ISettings _settings;
        private const string AssistantBehaviorDescription = "You are a Igadi Yami assistant that will help users learn everything about Igadi Yami and sustain crops for providing meals for their family, have a natural response to users which are easy to understand, Do not give robotic responses";

        public IgadiYamiAiAssistant(ISettings settings)
        {
            _settings = settings;
        }

        private IList<ChatRequestMessage> BuildChatContext(IList<ChatMessage> chatInboundHistory, ChatMessage userMessage)
        {
            var chatContext = new List<ChatRequestMessage>();

            chatContext.Add(new ChatRequestSystemMessage(AssistantBehaviorDescription));

            foreach (var chatMessage in chatInboundHistory)
                chatContext.Add(new ChatRequestAssistantMessage(chatMessage.MessageBody));

            chatContext.Add(new ChatRequestUserMessage(userMessage.MessageBody));

            return chatContext;

        }

        public ChatResponseMessage GetCompletion(IList<ChatMessage> chatInboundHistory, ChatMessage userMessage)
        {
            var messages = BuildChatContext(chatInboundHistory, userMessage);// list of everything that has been said so far

            var client = new OpenAIClient(new Uri(_settings.AzureOpenAiEndPoint), new AzureKeyCredential(_settings.AzureOpenAiKey));
            string deploymentName = "igadiyamichtbot";
            string searchIndex = "index";

            var chatCompletionsOptions = new ChatCompletionsOptions()
            {
                AzureExtensionsOptions = new AzureChatExtensionsOptions()
                {
                    Extensions =
        {
            new AzureSearchChatExtensionConfiguration()
            {
                SearchEndpoint = new Uri(_settings.AzureSearchEndPoint),
                Authentication = new OnYourDataApiKeyAuthenticationOptions(_settings.AzureSearchKey),

                IndexName = searchIndex,
            },
                    }
                },
                DeploymentName = deploymentName
            };

            foreach (var message in messages)
                chatCompletionsOptions.Messages.Add(message);

            Response<ChatCompletions> response = client.GetChatCompletions(chatCompletionsOptions);

            ChatResponseMessage responseMessage = response.Value.Choices[0].Message;

            return responseMessage;

        }
    }
}
