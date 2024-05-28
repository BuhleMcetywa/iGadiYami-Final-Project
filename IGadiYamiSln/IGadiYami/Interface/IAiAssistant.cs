using Azure.AI.OpenAI;
using IGadiYami.Models.ChatbotFolder;

namespace IGadiYami.Interface
{
    public interface IAiAssistant
    {
        ChatResponseMessage GetCompletion(IList<ChatMessage> chatInboundHistory, ChatMessage userMessage);
    }
}
