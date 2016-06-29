using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace TalkToTheBot
{
    public partial class TalkToTheBot : Form
    {
        public TalkToTheBot()
        {
            InitializeComponent();
        }

        string enteredText;
        string botAnswer;

        private void Enter_Click(object sender, EventArgs e)
        {
            if (textToEnter.Text != "")
            {
                chatTextBox.AppendText("User: " + textToEnter.Text + "\n");
                enteredText = textToEnter.Text.ToLower();

                List<Assembly> botList = new List<Assembly>();
                botList.Add(Assembly.LoadFrom("ChatBotGreeting.dll"));
                botList.Add(Assembly.LoadFrom("ChatBotConversation.dll"));
                botList.Add(Assembly.LoadFrom("ChatBotFarewell.dll"));
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
                chatTextBox.AppendText("Chat Bot: " + botAnswer + "\n");
                botAnswer = null;
            }
        }
    }
}
