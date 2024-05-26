using Org.BouncyCastle.Asn1.Crmf;
using System.Xml.Linq;

namespace Lab5
{
    partial class B5_Reply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B5_Reply));
            mailfrom = new TextBox();
            name = new TextBox();
            subject = new TextBox();
            mailto = new TextBox();
            richTextBox1 = new RichTextBox();
            path = new TextBox();
            browse = new Button();
            send = new Button();
            openFileDialog = new OpenFileDialog();
            checkBox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // mailfrom
            // 
            mailfrom.BackColor = Color.Ivory;
            mailfrom.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailfrom.Location = new Point(91, 20);
            mailfrom.Name = "mailfrom";
            mailfrom.ReadOnly = true;
            mailfrom.Size = new Size(330, 30);
            mailfrom.TabIndex = 0;
            // 
            // name
            // 
            name.BackColor = Color.Ivory;
            name.Font = new Font("Century Gothic", 9F);
            name.Location = new Point(91, 58);
            name.Name = "name";
            name.Size = new Size(330, 30);
            name.TabIndex = 1;
            // 
            // subject
            // 
            subject.BackColor = Color.Ivory;
            subject.Font = new Font("Century Gothic", 9F);
            subject.Location = new Point(91, 129);
            subject.Name = "subject";
            subject.Size = new Size(330, 30);
            subject.TabIndex = 2;
            // 
            // mailto
            // 
            mailto.BackColor = Color.Ivory;
            mailto.Font = new Font("Century Gothic", 9F);
            mailto.Location = new Point(91, 92);
            mailto.Name = "mailto";
            mailto.Size = new Size(330, 30);
            mailto.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlLightLight;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("Century Gothic", 9F);
            richTextBox1.ForeColor = Color.DarkSlateGray;
            richTextBox1.Location = new Point(12, 200);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(410, 378);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // path
            // 
            path.BackColor = Color.MintCream;
            path.BorderStyle = BorderStyle.FixedSingle;
            path.Font = new Font("Century Gothic", 9F);
            path.Location = new Point(68, 595);
            path.Name = "path";
            path.Size = new Size(246, 30);
            path.TabIndex = 6;
            // 
            // browse
            // 
            browse.BackColor = Color.Transparent;
            browse.FlatAppearance.BorderColor = Color.Green;
            browse.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            browse.Location = new Point(320, 594);
            browse.Name = "browse";
            browse.Size = new Size(106, 32);
            browse.TabIndex = 7;
            browse.Text = "Browse";
            browse.UseVisualStyleBackColor = false;
            browse.Click += browse_Click;
            // 
            // send
            // 
            send.BackColor = Color.Transparent;
            send.FlatAppearance.BorderColor = Color.Green;
            send.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            send.Location = new Point(320, 632);
            send.Name = "send";
            send.Size = new Size(106, 44);
            send.TabIndex = 8;
            send.Text = "Send";
            send.UseVisualStyleBackColor = false;
            send.Click += send_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.BackColor = Color.Transparent;
            checkBox.FlatStyle = FlatStyle.Flat;
            checkBox.ForeColor = Color.DarkGreen;
            checkBox.Location = new Point(97, 166);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(17, 16);
            checkBox.TabIndex = 9;
            checkBox.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(59, 22);
            label1.TabIndex = 10;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(35, 22);
            label2.TabIndex = 11;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 12;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(12, 132);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 13;
            label4.Text = "Subject:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(12, 166);
            label5.Name = "label5";
            label5.Size = new Size(59, 22);
            label5.TabIndex = 14;
            label5.Text = "Body:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(120, 162);
            label6.Name = "label6";
            label6.Size = new Size(54, 22);
            label6.TabIndex = 15;
            label6.Text = "HTML";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(12, 597);
            label7.Name = "label7";
            label7.Size = new Size(53, 22);
            label7.TabIndex = 16;
            label7.Text = "Path:";
            // 
            // B5_Reply
            // 
            AutoScaleMode = AutoScaleMode.None;
      
            ClientSize = new Size(436, 699);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox);
            Controls.Add(send);
            Controls.Add(browse);
            Controls.Add(path);
            Controls.Add(richTextBox1);
            Controls.Add(mailto);
            Controls.Add(subject);
            Controls.Add(name);
            Controls.Add(mailfrom);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "B5_Reply";
            Text = "Reply Mail";
            Load += Bai5_SendMail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox mailfrom;
        private TextBox name;
        public TextBox subject;
        public TextBox mailto;
        private RichTextBox richTextBox1;
        private TextBox path;
        private Button browse;
        private Button send;
        private OpenFileDialog openFileDialog;
        private CheckBox checkBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}