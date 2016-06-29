using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatBotGreeting
{
    public class ChatBotGreeting
    {
        public string GreetingAnswer(string sGreeting)
        {
            string sGreetingAnswer = null;

            List<string> greetingsList = new List<string>();
            greetingsList.Add("hi");
            greetingsList.Add("hello");

            if (greetingsList.Contains(sGreeting))
            {
                sGreetingAnswer = "Hello!";
            }

            return sGreetingAnswer;
        }
    }
}
