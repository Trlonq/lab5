using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;


namespace Lab5
{
    public partial class B5_Reply : Form
    {
        public B5_Reply()
        {
            InitializeComponent();
        }

        public string email { get; set; }
        public string password { get; set; }

        bool IsValidEmail(string email)
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

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path.Visible = true;
                path.Text = openFileDialog.FileName;
            }
        }

        private async void send_Click(object sender, EventArgs e)
        {
            try
            {
                using (var smtpClient = new SmtpClient())
                {
                    await smtpClient.ConnectAsync("smtp.gmail.com", 465, true);
                    await smtpClient.AuthenticateAsync(email, password);

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress(name.Text, mailfrom.Text));

                    if (IsValidEmail(mailto.Text))
                    {
                        message.To.Add(new MailboxAddress("", mailto.Text));

                        message.Subject = subject.Text;

                        var body = new TextPart(checkBox.Checked ? "html" : "plain")
                        {
                            Text = richTextBox1.Text
                        };
                        var multipart = new Multipart("mixed");
                        multipart.Add(body);

                        if (!string.IsNullOrEmpty(path.Text) && File.Exists(path.Text))
                        {
                            var attachment = new MimePart("application", "octet-stream")
                            {
                                Content = new MimeContent(File.OpenRead(path.Text)),
                                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                                ContentTransferEncoding = ContentEncoding.Base64,
                                FileName = Path.GetFileName(path.Text)
                            };
                            multipart.Add(attachment);
                        }

                        message.Body = multipart;

                        await smtpClient.SendAsync(message);
                        MessageBox.Show("Message has been sent");
                    }
                    else
                    {
                        MessageBox.Show("Invalid email");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Bai5_SendMail_Load(object sender, EventArgs e)
        {
            mailfrom.Text = email;
        }
    }
}
