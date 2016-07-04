using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace TalkToTheBot
{
    public class BotAnswer
    {
        static public List<Assembly> BotAssembly()
        {
            List<Assembly> botList = new List<Assembly>();
            string botPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (string botDLL in Directory.GetFiles(botPath, "*.dll"))
            {
                botList.Add(Assembly.LoadFile(botDLL));
            }
            return botList;
        }

        static public string BotAnswerMethod(string enteredText, List<Assembly> botList)
        {
            string botAnswer = null;
            foreach (Assembly chatBot in botList)
            {
                foreach (Type botType in chatBot.GetTypes())
                {
                    object botTypeObj = Activator.CreateInstance(botType);
                    foreach (MethodInfo botMethod in botType.GetMethods())
                    {
                        if (botMethod.Name == "ToString" || botMethod.Name == "GetHashCode" || botMethod.Name == "GetType")
                        {
                            continue;
                        }
                        else
                        {
                            object botAnswerObj = botMethod.Invoke(botTypeObj, new object[] { enteredText });

                            try
                            {
                                if (botAnswerObj.ToString() == "False")
                                {
                                }
                                else
                                {
                                    botAnswer = botAnswerObj.ToString();
                                }
                            }
                            catch (NullReferenceException)
                            {
                                continue;
                            }
                        }
                    }
                }
            }
            return botAnswer;
        }
    }
}
