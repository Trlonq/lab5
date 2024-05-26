using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bai1_Click(object sender, EventArgs e)
        {
            B1_MainForm a = new B1_MainForm();
            a.Show();
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            B2_MainForm b = new B2_MainForm();
            b.Show();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
             //B3_MainForm c = new B3_MainForm();
            // c.Show();
        }

        private void bai4_Click(object sender, EventArgs e)
        {
           // B4_MainForm d = new B4_MainForm();
           // d.Show();
        }

        private void bai5_Click(object sender, EventArgs e)
        {
            B5_MainForm f = new B5_MainForm();
            f.Show();
        }
    }
}
