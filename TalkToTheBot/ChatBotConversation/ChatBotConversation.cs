using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatBotConversation
{
    public class ChatBotConversation
    {
        public string ConversationAnswer(string sConversation)
        {
            string sConversationAnswer = null;

            List<string> conversationList = new List<string>();
            conversationList.Add("how are you?");

            if (conversationList.Contains(sConversation))
            {
                sConversationAnswer = "I'm fine, thank you. And you?";
            }

            return sConversationAnswer;
        }
    }
}
