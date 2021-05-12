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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usertextbox.Text == "Police" && textboxpassword.Text == "100")
            {
                MessageBox.Show("LOGIN SUCESSFULLY");
                homepage hg = new homepage();
                hg.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("LOGIN INVALID"); }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.OrangeRed;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {

            button2.BackColor = Color.GreenYellow;
        }

        }
    }

