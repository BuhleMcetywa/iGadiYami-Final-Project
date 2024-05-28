using IGadiYami.Enums;

namespace IGadiYami.Models.ChatbotFolder
{
    public class ChatMessage
    {
        public ChatMessageTypeEnum MessageType { get; set; }
        public string? MessageBody { get; set; }

    }
}
