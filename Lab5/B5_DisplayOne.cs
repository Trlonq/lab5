using Lab5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab5
{
    public partial class B5_DisplayOne : Form
    {
        public string User;
        public string Password;

        public B5_DisplayOne(string from, string to, string subject, string body)
        {
            InitializeComponent();
            SetEmailDetails(from, to, subject);
            LoadHtmlAsync(body);
        }

        private async void LoadHtmlAsync(string htmlContent)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.NavigateToString(htmlContent);
        }

        private void SetEmailDetails(string from, string to, string subject)
        {
            textbox_from.Text = from;
            textbox_to.Text = to;
            label_Subject.Text = subject;
        }

        private void reply_Click(object sender, EventArgs e)
        {
            B5_Reply reply = new B5_Reply();
            reply.password = Password;

            string senderEmail = ExtractSenderEmail(textbox_from.Text);
            string replySubject = $"RE: {label_Subject.Text}";
            reply.mailto.Text = senderEmail;
            reply.email = User;

            reply.ShowDialog();
        }

        private string ExtractSenderEmail(string senderInfo)
        {
            int startIndex = senderInfo.IndexOf("<") + 1;
            int endIndex = senderInfo.IndexOf(">", startIndex);
            return senderInfo.Substring(startIndex, endIndex - startIndex);
        }
    }
}