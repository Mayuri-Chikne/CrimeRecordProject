using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
namespace crimeproject
{
    public partial class fir : Form
    {
        public fir()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void fir_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox4.Width - 3, pictureBox4.Height - 3);
            Region rg = new Region(gp);
            pictureBox4.Region = rg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91830\Documents\Visual Studio 2010\Projects\crimeproject\crimeproject\crimeproject.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into fir values(" + firnotextbox.Text + ",'" +firdateTimePicker.Text + "','" + stationnametextbox.Text + "','" + descriptiontextbox.Text + "','" +offencetextbox.Text + "','" + coptextbox.Text+ "')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Added Sucessfully");
        }

        private void hOMEPAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homepage hp = new homepage();
            hp.Show();
            this.Hide();
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stations st = new stations();
            st.Show();
            this.Hide();
        }

        private void cRIMINALMODULEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polices p = new polices();
            p.Show();
            this.Hide();
        }

        private void oWEFKFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            criminals c = new criminals();
            c.Show();
            this.Hide();
        }

        private void sTATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

            stationview sv = new stationview();
            sv.Show();
            this.Hide();
        }

        private void pOLICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            policeview pv = new policeview();
            pv.Show();
            this.Hide();
        }

        private void cRIMINALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            criminalview cv = new criminalview();
            cv.Show();
            this.Hide();
        }

        private void fIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firview fv = new firview();
            fv.Show();
            this.Hide();

        }

        private void cONTACTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contactus cu = new contactus();
            cu.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            fir fr = new fir();
            fr.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Firstpage f1 = new Firstpage();
            f1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
