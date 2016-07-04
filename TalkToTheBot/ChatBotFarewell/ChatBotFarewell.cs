using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatBotFarewell
{
    public class ChatBotFarewell
    {
        public string FarewellAnswer(string sFarewell)
        {
            string sFarewellAnswer = null;

            List<string> farewellList = new List<string>();
            farewellList.Add("bye");
            farewellList.Add("goodbye");

            if (farewellList.Contains(sFarewell))
            {
                sFarewellAnswer = "Goodbye!";
            }

            return sFarewellAnswer;
        }
    }
}
