using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace crimeproject
{
    public partial class Firstpage : Form
    {
        public Firstpage()
        {
            this.BackColor = Color.Black;
            InitializeComponent();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
           // this.Size = new System.Drawing.Size(1900, 900);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
