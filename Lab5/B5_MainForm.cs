using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;
using Lab5;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.VisualBasic.Logging;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Lab5
{
    public partial class B5_MainForm : Form
    {
        private List<string> linkMail = new List<string>();

        public B5_MainForm()
        {
            InitializeComponent();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            SetLoginFormState(true);
        }

        // Kiểm tra tính hợp lệ của địa chỉ email
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }


        // Lấy email từ server IMAP
        private void GetMail(string username, string password)
        {
            using (var client = new ImapClient())
            {
                try
                {
                    client.Connect(imapBox.Text, Int16.Parse(imapPort.Text), SecureSocketOptions.SslOnConnect);
                    client.Authenticate(username, password);
                    SetLoginFormState(false);
                    ProcessIncomingEmails(client.Inbox);
                }
                catch
                {
                    MessageBox.Show("Incorrect password");
                    SetLoginFormState(true);
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }

        // Xử lý các email đến và hiển thị trên DataGridView
        private void ProcessIncomingEmails(IMailFolder inboxMail)
        {
            inboxMail.Open(FolderAccess.ReadOnly);
            var messages = inboxMail.Fetch(0, -1, MessageSummaryItems.UniqueId | MessageSummaryItems.Envelope | MessageSummaryItems.Body)
                .OrderByDescending(x => x.Date)
                .Take(20);

            foreach (var message in messages)
            {
                var email = inboxMail.GetMessage(message.UniqueId);
                var from = message.Envelope.From.ToString();
                var subject = message.Envelope.Subject;
                var date = message.Date.LocalDateTime.ToString();

                AddRowToDataGridView(email.HtmlBody, from, subject, date);
            }
        }

        // Thêm một dòng mới vào DataGridView
        private void AddRowToDataGridView(string body, string from, string subject, string date)
        {
            var row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell { Value = (dataGridView.Rows.Count + 1).ToString(), Tag = body });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = from });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = subject });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = date });
            dataGridView.Rows.Add(row);
        }

        // Thiết lập trạng thái của các điều khiển trên form đăng nhập
        private void SetLoginFormState(bool enabled)
        {
            logout.Visible = !enabled;
            refresh.Visible = !enabled;
            sendMail.Visible = !enabled;
            login.Visible = enabled;
            username.ReadOnly = !enabled;
            password.ReadOnly = !enabled;
        }

        // Xử lý sự kiện nhấn nút Đăng nhập
        private void login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            if (!IsValidEmail(username.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            try
            {
                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Connect("smtp.gmail.com", 465, true);
                    GetMail(username.Text, password.Text);
                }
            }
            catch
            {
                MessageBox.Show("LOGIN FAILED");
            }
        }

        // Xử lý sự kiện nhấn nút Đăng xuất
        private void logout_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            SetLoginFormState(true);
            username.Text = "";
            password.Text = "";
        }

        // Xóa tất cả các dòng trong DataGridView
        private void ClearDataGridView()
        {
            dataGridView.Rows.Clear();
        }

        // Xử lý sự kiện nhấn nút Làm mới
        private void refresh_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            GetMail(username.Text, password.Text);
        }

        // Xử lý sự kiện nhấn nút Gửi email
        private void sendMail_Click(object sender, EventArgs e)
        {
            OpenSendMailForm();
        }

        // Mở form gửi email mới
        private void OpenSendMailForm()
        {
            var sendMailForm = new B5_Reply();
            sendMailForm.email = username.Text;
            sendMailForm.password = password.Text;
            sendMailForm.ShowDialog();
        }

        // Xử lý sự kiện nhấn vào một ô trong DataGridView
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string body = dataGridView.Rows[e.RowIndex].Cells[0].Tag.ToString();
                string from = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string to = username.Text;
                string subject = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                OpenViewMailForm(from, to, subject, body);
            }
        }

        // Mở form xem email chi tiết
        private void OpenViewMailForm(string from, string to, string subject, string body)
        {
            var viewMailForm = new B5_DisplayOne(from, to, subject, body);
            viewMailForm.User = username.Text;
            viewMailForm.Password = password.Text;
            viewMailForm.ShowDialog();
        }
    }
}
