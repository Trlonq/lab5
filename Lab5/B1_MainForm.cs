using System;
using System.Net.Mail;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;


namespace Lab5
{
    public partial class B1_MainForm : Form
    {
        public B1_MainForm()
        {
            InitializeComponent();
        }

        // Method to validate email address
        private bool IsValidEmailAddress(string emailAddress)
        {
            try
            {
                var mailAddress = new MailAddress(emailAddress);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Method to send email
        private void SendEmail(string fromEmail, string toEmail, string emailSubject, string emailBody)
        {
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.gmail.com", 465, true);
                smtpClient.Authenticate("bqmxnh@gmail.com", "bisw kqwh insu pewm\n");

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("", fromEmail));
                message.To.Add(new MailboxAddress("", toEmail));
                message.Subject = emailSubject;
                message.Body = new TextPart("plain")
                {
                    Text = emailBody
                };

                smtpClient.Send(message);
                smtpClient.Disconnect(true);
            }
        }

        // Event handler for the send button click
        private void sendButton_Click(object sender, EventArgs e)
        {
            string fromEmail = fromTextBox.Text;
            string toEmail = toTextBox.Text;
            string emailSubject = subjectTextBox.Text;
            string emailBody = bodyTextBox.Text;

            if (!IsValidEmailAddress(toEmail))
            {
                MessageBox.Show("Please enter a valid email address.");
                toTextBox.Clear();
                return;
            }

            try
            {
                SendEmail(fromEmail, toEmail, emailSubject, emailBody);
                MessageBox.Show("Message has been sent");
                toTextBox.Clear();
                subjectTextBox.Clear();
                bodyTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR!\nPlease check and try again.\n{ex.Message}");
            }
        }
    }
}
