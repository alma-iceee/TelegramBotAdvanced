using System.Collections.Generic;

namespace TelegramBotAdvanced
{
    public class MessageInfo
    {
        public long ChatId { get; set; }
        public string UserName { get; set; }
        
        public MessageInfo() { }

        public MessageInfo(long chatId, string userName)
        {
            ChatId = chatId;
            UserName = userName;
        }
    }
}
