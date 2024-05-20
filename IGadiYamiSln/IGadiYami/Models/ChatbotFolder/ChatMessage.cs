using IGadiYami.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.Models.ChatbotFolder
{
    public class ChatMessage
    {
        public ChatMessageTypeEnum MessageType { get; set; }
        public string? MessageBody { get; set; }

    }
}
