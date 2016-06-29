namespace TalkToTheBot
{
    partial class TalkToTheBot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textToEnter = new System.Windows.Forms.TextBox();
            this.chatTextBox = new System.Windows.Forms.RichTextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textToEnter
            // 
            this.textToEnter.Location = new System.Drawing.Point(12, 268);
            this.textToEnter.Name = "textToEnter";
            this.textToEnter.Size = new System.Drawing.Size(518, 20);
            this.textToEnter.TabIndex = 0;
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(12, 12);
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.Size = new System.Drawing.Size(626, 250);
            this.chatTextBox.TabIndex = 2;
            this.chatTextBox.Text = "";
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(536, 268);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(102, 20);
            this.Enter.TabIndex = 3;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // TalkToTheBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 300);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.textToEnter);
            this.Name = "TalkToTheBot";
            this.Text = "TalkToTheBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textToEnter;
        private System.Windows.Forms.RichTextBox chatTextBox;
        private System.Windows.Forms.Button Enter;
    }
}

