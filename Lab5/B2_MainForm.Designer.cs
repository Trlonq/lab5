using Org.BouncyCastle.Asn1.Crmf;
using System.Xml.Linq;

namespace Lab5
{
    partial class B2_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B2_MainForm));
            dataGridView1 = new DataGridView();
            column_email = new DataGridViewTextBoxColumn();
            column_from = new DataGridViewTextBoxColumn();
            column_time = new DataGridViewTextBoxColumn();
            button_login = new Button();
            textbox_password = new TextBox();
            textbox_email = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.CadetBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column_email, column_from, column_time });
            dataGridView1.Location = new Point(76, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(763, 301);
            dataGridView1.TabIndex = 7;
            // 
            // column_email
            // 
            column_email.HeaderText = "Email";
            column_email.MinimumWidth = 6;
            column_email.Name = "column_email";
            column_email.ReadOnly = true;
            column_email.Resizable = DataGridViewTriState.False;
            column_email.Width = 300;
            // 
            // column_from
            // 
            column_from.HeaderText = "From";
            column_from.MinimumWidth = 6;
            column_from.Name = "column_from";
            column_from.ReadOnly = true;
            column_from.Resizable = DataGridViewTriState.False;
            column_from.Width = 230;
            // 
            // column_time
            // 
            column_time.HeaderText = "Time";
            column_time.MinimumWidth = 6;
            column_time.Name = "column_time";
            column_time.ReadOnly = true;
            column_time.Resizable = DataGridViewTriState.False;
            column_time.Width = 180;
            // 
            // button_login
            // 
            button_login.BackColor = Color.Gainsboro;
            button_login.FlatAppearance.BorderSize = 0;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.ForeColor = SystemColors.ActiveCaptionText;
            button_login.Location = new Point(641, 46);
            button_login.Name = "button_login";
            button_login.Size = new Size(285, 74);
            button_login.TabIndex = 6;
            button_login.Text = "login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // textbox_password
            // 
            textbox_password.BackColor = SystemColors.ControlLightLight;
            textbox_password.Font = new Font("Segoe UI", 10.8F);
            textbox_password.ForeColor = Color.CadetBlue;
            textbox_password.Location = new Point(208, 119);
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.Size = new Size(426, 46);
            textbox_password.TabIndex = 5;
            textbox_password.Text = "bisw kqwh insu pewm";
            // 
            // textbox_email
            // 
            textbox_email.BackColor = SystemColors.ControlLightLight;
            textbox_email.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textbox_email.ForeColor = Color.CadetBlue;
            textbox_email.Location = new Point(149, 46);
            textbox_email.Name = "textbox_email";
            textbox_email.Size = new Size(426, 47);
            textbox_email.TabIndex = 4;
            textbox_email.Text = "trantrunglong12@gmail.com";
            // 
            // B2_MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(938, 484);
            Controls.Add(dataGridView1);
            Controls.Add(button_login);
            Controls.Add(textbox_password);
            Controls.Add(textbox_email);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "B2_MainForm";
            Text = "Bài 2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn column_email;
        private DataGridViewTextBoxColumn column_from;
        private DataGridViewTextBoxColumn column_time;
        private Button button_login;
        private TextBox textbox_password;
        private TextBox textbox_email;
    }
}