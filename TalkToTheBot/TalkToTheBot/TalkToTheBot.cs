using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace TalkToTheBot
{
    public partial class TalkToTheBot : Form
    {
        string enteredText;
        string botAnswer;
        List<Assembly> botList;

        public TalkToTheBot()
        {
            InitializeComponent();
            botList = BotAnswer.BotAssembly();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (textToEnter.Text != "")
            {
                chatTextBox.AppendText("User: " + textToEnter.Text + "\n");
                enteredText = textToEnter.Text.ToLower();
                botAnswer = BotAnswer.BotAnswerMethod(enteredText, botList);
                chatTextBox.AppendText("Chat Bot: " + botAnswer + "\n");
                botAnswer = null;
            }
        }
    }
}
