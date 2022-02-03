
namespace Warehouse
{
    partial class Message
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
            this.messageButton = new System.Windows.Forms.Button();
            this.messageText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(125, 97);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(112, 34);
            this.messageButton.TabIndex = 0;
            this.messageButton.Text = "button1";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.Location = new System.Drawing.Point(12, 45);
            this.messageText.MinimumSize = new System.Drawing.Size(340, 0);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(340, 25);
            this.messageText.TabIndex = 1;
            this.messageText.Text = "label1";
            this.messageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 143);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.messageButton);
            this.Name = "Message";
            this.Text = "Message";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Label messageText;
    }
}