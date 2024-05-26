﻿using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Lab5
{
    partial class B5_DisplayOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B5_DisplayOne));
            textbox_from = new TextBox();
            textbox_to = new TextBox();
            reply = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label_Subject = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // textbox_from
            // 
            textbox_from.BackColor = SystemColors.ControlLightLight;
            textbox_from.Font = new System.Drawing.Font("Century Gothic", 9F);
            textbox_from.Location = new Point(90, 20);
            textbox_from.Name = "textbox_from";
            textbox_from.ReadOnly = true;
            textbox_from.Size = new Size(302, 30);
            textbox_from.TabIndex = 1;
            // 
            // textbox_to
            // 
            textbox_to.BackColor = SystemColors.ControlLightLight;
            textbox_to.Font = new System.Drawing.Font("Century Gothic", 9F);
            textbox_to.Location = new Point(90, 57);
            textbox_to.Name = "textbox_to";
            textbox_to.ReadOnly = true;
            textbox_to.Size = new Size(302, 30);
            textbox_to.TabIndex = 2;
            // 
            // reply
            // 
            reply.BackColor = Color.Transparent;
            reply.FlatAppearance.BorderColor = Color.Green;
            reply.Font = new System.Drawing.Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reply.Location = new Point(436, 15);
            reply.Name = "reply";
            reply.Size = new Size(100, 68);
            reply.TabIndex = 3;
            reply.Text = "Reply";
            reply.UseVisualStyleBackColor = false;
            reply.Click += reply_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 140);
            webView21.Name = "webView21";
            webView21.Size = new Size(538, 507);
            webView21.TabIndex = 4;
            webView21.ZoomFactor = 1D;
            // 
            // label_Subject
            // 
            label_Subject.AutoSize = true;
            label_Subject.BackColor = Color.Transparent;
            label_Subject.ForeColor = Color.FromArgb(125, 153, 117);
            label_Subject.Location = new Point(27, 95);
            label_Subject.MaximumSize = new Size(520, 100);
            label_Subject.Name = "label_Subject";
            label_Subject.Size = new Size(0, 25);
            label_Subject.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9F, FontStyle.Bold);
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(59, 22);
            label1.TabIndex = 6;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 9F, FontStyle.Bold);
            label2.Location = new Point(50, 60);
            label2.Name = "label2";
            label2.Size = new Size(35, 22);
            label2.TabIndex = 7;
            label2.Text = "To:";
            // 
            // B5_DisplayOne
            // 
            AutoScaleMode = AutoScaleMode.None;
         
            ClientSize = new Size(562, 669);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_Subject);
            Controls.Add(webView21);
            Controls.Add(reply);
            Controls.Add(textbox_to);
            Controls.Add(textbox_from);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "B5_DisplayOne";
            Text = "Display Mail";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textbox_from;
        private TextBox textbox_to;
        private Button reply;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label label_Subject;
        private Label label1;
        private Label label2;
    }
}