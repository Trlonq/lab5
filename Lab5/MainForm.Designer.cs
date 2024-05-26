using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Lab5
{
    partial class MainForm
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
            bai1 = new Button();
            bai2 = new Button();
            bai3 = new Button();
            bai4 = new Button();
            bai5 = new Button();
            SuspendLayout();
            // 
            // bai1
            // 
            bai1.BackColor = Color.Gainsboro;
            bai1.FlatAppearance.BorderSize = 0;
            bai1.FlatStyle = FlatStyle.Flat;
            bai1.Location = new Point(72, 214);
            bai1.Margin = new Padding(4);
            bai1.Name = "bai1";
            bai1.Size = new Size(333, 91);
            bai1.TabIndex = 0;
            bai1.Text = "Bài 1";
            bai1.UseVisualStyleBackColor = false;
            bai1.Click += bai1_Click;
            // 
            // bai2
            // 
            bai2.BackColor = Color.Gainsboro;
            bai2.FlatAppearance.BorderSize = 0;
            bai2.FlatStyle = FlatStyle.Flat;
            bai2.Location = new Point(450, 214);
            bai2.Margin = new Padding(4);
            bai2.Name = "bai2";
            bai2.Size = new Size(334, 91);
            bai2.TabIndex = 1;
            bai2.Text = "Bài 2";
            bai2.UseVisualStyleBackColor = false;
            bai2.Click += bai2_Click;
            // 
            // bai3
            // 
            bai3.BackColor = Color.Gainsboro;
            bai3.FlatAppearance.BorderSize = 0;
            bai3.FlatStyle = FlatStyle.Flat;
            bai3.Location = new Point(842, 214);
            bai3.Margin = new Padding(4);
            bai3.Name = "bai3";
            bai3.Size = new Size(335, 91);
            bai3.TabIndex = 2;
            bai3.Text = "Bài 3";
            bai3.UseVisualStyleBackColor = false;
            bai3.Click += bai3_Click;
            // 
            // bai4
            // 
            bai4.BackColor = Color.Gainsboro;
            bai4.FlatAppearance.BorderSize = 0;
            bai4.FlatStyle = FlatStyle.Flat;
            bai4.Location = new Point(263, 399);
            bai4.Margin = new Padding(4);
            bai4.Name = "bai4";
            bai4.Size = new Size(330, 91);
            bai4.TabIndex = 3;
            bai4.Text = "Bài 4";
            bai4.UseVisualStyleBackColor = false;
            bai4.Click += bai4_Click;
            // 
            // bai5
            // 
            bai5.BackColor = Color.Gainsboro;
            bai5.FlatAppearance.BorderSize = 0;
            bai5.FlatStyle = FlatStyle.Flat;
            bai5.Location = new Point(653, 399);
            bai5.Margin = new Padding(4);
            bai5.Name = "bai5";
            bai5.Size = new Size(333, 91);
            bai5.TabIndex = 4;
            bai5.Text = "Bài 5";
            bai5.UseVisualStyleBackColor = false;
            bai5.Click += bai5_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 690);
            Controls.Add(bai5);
            Controls.Add(bai4);
            Controls.Add(bai3);
            Controls.Add(bai2);
            Controls.Add(bai1);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "LAB 5";
            ResumeLayout(false);
        }

        #endregion

        private Button bai1;
        private Button bai2;
        private Button bai3;
        private Button bai4;
        private Button bai5;
    }
}