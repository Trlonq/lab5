using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab5
{
    partial class B1_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B1_MainForm));
            fromTextBox = new TextBox();
            toTextBox = new TextBox();
            subjectTextBox = new TextBox();
            bodyTextBox = new RichTextBox();
            send = new Button();
            SuspendLayout();
            // 
            // fromTextBox
            // 
            fromTextBox.BackColor = SystemColors.ControlLightLight;
            fromTextBox.Font = new System.Drawing.Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fromTextBox.ForeColor = Color.DarkBlue;
            fromTextBox.Location = new Point(130, 23);
            fromTextBox.Multiline = true;
            fromTextBox.Name = "fromTextBox";
            fromTextBox.Size = new Size(418, 46);
            fromTextBox.TabIndex = 0;
            fromTextBox.Text = "trantrunglong12@gmail.com";
            // 
            // toTextBox
            // 
            toTextBox.BackColor = SystemColors.ControlLightLight;
            toTextBox.Font = new System.Drawing.Font("Arial Black", 12F, FontStyle.Bold);
            toTextBox.ForeColor = Color.DarkBlue;
            toTextBox.Location = new Point(130, 87);
            toTextBox.Multiline = true;
            toTextBox.Name = "toTextBox";
            toTextBox.Size = new Size(418, 46);
            toTextBox.TabIndex = 1;
            // 
            // subjectTextBox
            // 
            subjectTextBox.BackColor = SystemColors.ControlLightLight;
            subjectTextBox.Font = new System.Drawing.Font("Arial Black", 12F, FontStyle.Bold);
            subjectTextBox.ForeColor = Color.DarkBlue;
            subjectTextBox.Location = new Point(130, 152);
            subjectTextBox.Multiline = true;
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(780, 46);
            subjectTextBox.TabIndex = 2;
            // 
            // bodyTextBox
            // 
            bodyTextBox.BackColor = SystemColors.ControlLightLight;
            bodyTextBox.BorderStyle = BorderStyle.FixedSingle;
            bodyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            bodyTextBox.ForeColor = Color.DarkBlue;
            bodyTextBox.Location = new Point(130, 222);
            bodyTextBox.Name = "bodyTextBox";
            bodyTextBox.Size = new Size(780, 229);
            bodyTextBox.TabIndex = 3;
            bodyTextBox.Text = "";
            // 
            // send
            // 
            send.BackColor = Color.Transparent;
            send.FlatAppearance.BorderSize = 0;
            send.FlatStyle = FlatStyle.Flat;
            send.Location = new Point(609, 33);
            send.Name = "send";
            send.Size = new Size(301, 80);
            send.TabIndex = 4;
            send.UseVisualStyleBackColor = false;
            send.Click += sendButton_Click;
            // 
            // B1_MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(938, 484);
            Controls.Add(send);
            Controls.Add(bodyTextBox);
            Controls.Add(subjectTextBox);
            Controls.Add(toTextBox);
            Controls.Add(fromTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "B1_MainForm";
            Text = "Bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fromTextBox;
        private TextBox toTextBox;
        private TextBox subjectTextBox;
        private RichTextBox bodyTextBox;
        private Button send;
    }
}