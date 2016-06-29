using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatBotFarewell
{
    public class ChatBotFarewell
    {
        public string FarewellAnswer(string sGreeting)
        {
            string sFarewellAnswer = null;

            List<string> farewellList = new List<string>();
            farewellList.Add("bye");
            farewellList.Add("goodbye");

            if (farewellList.Contains(sGreeting))
            {
                sFarewellAnswer = "Goodbye!";
            }

            return sFarewellAnswer;
        }
    }
}
