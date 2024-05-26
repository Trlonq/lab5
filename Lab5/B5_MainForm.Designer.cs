using Org.BouncyCastle.Asn1.Crmf;
using System.Xml.Linq;

namespace Lab5
{
    partial class B5_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B5_MainForm));
            boxLogin = new GroupBox();
            logout = new Button();
            sendMail = new Button();
            refresh = new Button();
            login = new Button();
            label2 = new Label();
            label1 = new Label();
            password = new TextBox();
            username = new TextBox();
            groupBox2 = new GroupBox();
            smptPort = new TextBox();
            imapPort = new TextBox();
            smtpBox = new TextBox();
            imapBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView = new DataGridView();
            number = new DataGridViewTextBoxColumn();
            from = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            datetime = new DataGridViewTextBoxColumn();
            boxLogin.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // boxLogin
            // 
            boxLogin.BackColor = Color.Transparent;
            boxLogin.Controls.Add(logout);
            boxLogin.Controls.Add(sendMail);
            boxLogin.Controls.Add(refresh);
            boxLogin.Controls.Add(login);
            boxLogin.Controls.Add(label2);
            boxLogin.Controls.Add(label1);
            boxLogin.Controls.Add(password);
            boxLogin.Controls.Add(username);
            boxLogin.Font = new Font("Segoe UI", 9F);
            boxLogin.Location = new Point(17, 12);
            boxLogin.Name = "boxLogin";
            boxLogin.Size = new Size(380, 157);
            boxLogin.TabIndex = 0;
            boxLogin.TabStop = false;
            boxLogin.Text = "Đăng nhập";
            // 
            // logout
            // 
            logout.BackColor = SystemColors.ControlLightLight;
            logout.FlatAppearance.BorderSize = 0;
            logout.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            logout.Location = new Point(263, 112);
            logout.Name = "logout";
            logout.Size = new Size(105, 41);
            logout.TabIndex = 7;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Visible = false;
            logout.Click += logout_Click;
            // 
            // sendMail
            // 
            sendMail.BackColor = SystemColors.ControlLightLight;
            sendMail.FlatAppearance.BorderSize = 0;
            sendMail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            sendMail.Location = new Point(6, 110);
            sendMail.Name = "sendMail";
            sendMail.Size = new Size(105, 41);
            sendMail.TabIndex = 6;
            sendMail.Text = "Send";
            sendMail.UseVisualStyleBackColor = false;
            sendMail.Visible = false;
            sendMail.Click += sendMail_Click;
            // 
            // refresh
            // 
            refresh.BackColor = SystemColors.ControlLightLight;
            refresh.FlatAppearance.BorderSize = 0;
            refresh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            refresh.Location = new Point(137, 110);
            refresh.Name = "refresh";
            refresh.Size = new Size(105, 41);
            refresh.TabIndex = 5;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = false;
            refresh.Visible = false;
            refresh.Click += refresh_Click;
            // 
            // login
            // 
            login.BackColor = SystemColors.ControlLightLight;
            login.FlatAppearance.BorderSize = 0;
            login.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            login.Location = new Point(263, 112);
            login.Name = "login";
            login.Size = new Size(105, 40);
            login.TabIndex = 4;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.Location = new Point(5, 63);
            label2.Name = "label2";
            label2.Size = new Size(128, 29);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label1.Location = new Point(5, 30);
            label1.Name = "label1";
            label1.Size = new Size(79, 29);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // password
            // 
            password.BackColor = SystemColors.ButtonHighlight;
            password.Font = new Font("Microsoft Sans Serif", 9F);
            password.Location = new Point(101, 63);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(267, 35);
            password.TabIndex = 1;
            password.Text = "bisw kqwh insu pewm";
            // 
            // username
            // 
            username.BackColor = SystemColors.ButtonHighlight;
            username.Font = new Font("Microsoft Sans Serif", 9F);
            username.Location = new Point(101, 27);
            username.Name = "username";
            username.Size = new Size(267, 35);
            username.TabIndex = 0;
            username.Text = "trantrunglong12@gmail.com";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(smptPort);
            groupBox2.Controls.Add(imapPort);
            groupBox2.Controls.Add(smtpBox);
            groupBox2.Controls.Add(imapBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 9F);
            groupBox2.Location = new Point(403, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(503, 157);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Setting";
            // 
            // smptPort
            // 
            smptPort.BackColor = SystemColors.Window;
            smptPort.Font = new Font("Microsoft Sans Serif", 9F);
            smptPort.Location = new Point(315, 69);
            smptPort.Name = "smptPort";
            smptPort.ReadOnly = true;
            smptPort.Size = new Size(171, 35);
            smptPort.TabIndex = 6;
            smptPort.Text = "465";
            smptPort.TextAlign = HorizontalAlignment.Center;
            // 
            // imapPort
            // 
            imapPort.BackColor = SystemColors.Window;
            imapPort.Font = new Font("Microsoft Sans Serif", 9F);
            imapPort.Location = new Point(72, 69);
            imapPort.Name = "imapPort";
            imapPort.ReadOnly = true;
            imapPort.Size = new Size(171, 35);
            imapPort.TabIndex = 5;
            imapPort.Text = "993";
            imapPort.TextAlign = HorizontalAlignment.Center;
            // 
            // smtpBox
            // 
            smtpBox.BackColor = SystemColors.Window;
            smtpBox.Font = new Font("Microsoft Sans Serif", 9F);
            smtpBox.Location = new Point(315, 28);
            smtpBox.Multiline = true;
            smtpBox.Name = "smtpBox";
            smtpBox.ReadOnly = true;
            smtpBox.Size = new Size(171, 31);
            smtpBox.TabIndex = 4;
            smtpBox.Text = "smtp.gmail.com";
            smtpBox.TextAlign = HorizontalAlignment.Center;
            // 
            // imapBox
            // 
            imapBox.BackColor = SystemColors.Window;
            imapBox.Font = new Font("Microsoft Sans Serif", 9F);
            imapBox.Location = new Point(72, 27);
            imapBox.Name = "imapBox";
            imapBox.ReadOnly = true;
            imapBox.Size = new Size(171, 35);
            imapBox.TabIndex = 2;
            imapBox.Text = "imap.gmail.com";
            imapBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label6.Location = new Point(15, 69);
            label6.Name = "label6";
            label6.Size = new Size(61, 29);
            label6.TabIndex = 3;
            label6.Text = "Port";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label5.Location = new Point(261, 72);
            label5.Name = "label5";
            label5.Size = new Size(61, 29);
            label5.TabIndex = 2;
            label5.Text = "Port";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label4.Location = new Point(249, 32);
            label4.Name = "label4";
            label4.Size = new Size(85, 29);
            label4.TabIndex = 1;
            label4.Text = "SMTP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(74, 29);
            label3.TabIndex = 0;
            label3.Text = "IMAP";
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.GhostWhite;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { number, from, subject, datetime });
            dataGridView.Location = new Point(66, 189);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(804, 397);
            dataGridView.TabIndex = 2;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // number
            // 
            number.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            number.HeaderText = "No.";
            number.MinimumWidth = 6;
            number.Name = "number";
            number.ReadOnly = true;
            number.Resizable = DataGridViewTriState.False;
            number.Width = 50;
            // 
            // from
            // 
            from.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            from.HeaderText = "From";
            from.MinimumWidth = 6;
            from.Name = "from";
            from.ReadOnly = true;
            from.Resizable = DataGridViewTriState.False;
            from.Width = 200;
            // 
            // subject
            // 
            subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            subject.HeaderText = "Subject";
            subject.MinimumWidth = 6;
            subject.Name = "subject";
            subject.ReadOnly = true;
            subject.Resizable = DataGridViewTriState.False;
            subject.Width = 300;
            // 
            // datetime
            // 
            datetime.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            datetime.HeaderText = "Date & Time";
            datetime.MinimumWidth = 6;
            datetime.Name = "datetime";
            datetime.ReadOnly = true;
            datetime.Resizable = DataGridViewTriState.False;
            datetime.Width = 200;
            // 
            // B5_MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(985, 618);
            Controls.Add(dataGridView);
            Controls.Add(groupBox2);
            Controls.Add(boxLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "B5_MainForm";
            Text = "Bài 5";
            Load += Bai5_Load;
            boxLogin.ResumeLayout(false);
            boxLogin.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox boxLogin;
        private TextBox password;
        private TextBox username;
        private GroupBox groupBox2;
        private Button login;
        private Label label2;
        private Label label1;
        private TextBox smptPort;
        private TextBox imapPort;
        private TextBox smtpBox;
        private TextBox imapBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button sendMail;
        private Button refresh;
        private Button logout;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn from;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn datetime;
    }
}