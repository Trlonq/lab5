using System;
using System.Net;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Security;

namespace Lab5
{
    public partial class B2_MainForm : Form
    {
        public B2_MainForm()
        {
            InitializeComponent();
        }

        private void GetMail(string username, string password)
        {
            using (var imapClient = new ImapClient())
            {
                try
                {
                    imapClient.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    imapClient.Authenticate(username, password);

                    textbox_email.ReadOnly = true;
                    textbox_password.ReadOnly = true;

                    var inbox = imapClient.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);

                    dataGridView1.Rows.Clear();

                    int index = 1;
                    for (int i = inbox.Count - 1; i >= 0 && index <= 20; i--)
                    {
                        var message = inbox.GetMessage(i);

                        var from = message.From.ToString();
                        var subject = message.Subject;
                        var date = message.Date.LocalDateTime.ToString();

                        dataGridView1.Rows.Add(subject, from, date);

                        index++;
                    }

                    imapClient.Disconnect(true);
                }
                catch (AuthenticationException)
                {
                    MessageBox.Show("Incorrect password");
                    textbox_password.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string email = textbox_email.Text.Trim();
            string password = textbox_password.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            GetMail(email, password);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }

        }
    }
}
