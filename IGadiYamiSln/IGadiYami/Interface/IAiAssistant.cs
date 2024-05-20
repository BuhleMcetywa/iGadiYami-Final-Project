using Azure.AI.OpenAI;
using IGadiYami.Models.ChatbotFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Interface
{
    public interface IAiAssistant
    {
        ChatResponseMessage GetCompletion(IList<ChatMessage> chatInboundHistory, ChatMessage userMessage);
    }
}
