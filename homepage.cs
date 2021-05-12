using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace crimeproject
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }



        private void homepage_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox4.Width - 3, pictureBox4.Height - 3);
            Region rg = new Region(gp);
            pictureBox4.Region = rg;
           
        }

   

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


     
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

      


     

        private void aBOUTUSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

         stations ss = new stations();
            ss.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Firstpage f1 = new Firstpage();
            f1.Show();
            this.Hide();
        }

        private void hOMEPAGEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            homepage hp = new homepage();
            hp.Show();
            this.Hide();

        }

        private void oWEFKFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            criminals c = new criminals();
            c.Show();
            this.Hide();
        }

        private void cRIMINALMODULEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polices p = new polices();
            p.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           fir fr = new  fir();
            fr.Show();
            this.Hide();
        }

        private void cONTACTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            contactus cu  = new contactus();
            cu.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
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

        private void fIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
           firview fv = new  firview();
            fv.Show();
            this.Hide();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Firstpage f1 = new Firstpage();
            f1.Show();
            this.Hide();
        }

        private void cRIMINALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            criminalview cv = new criminalview();
            cv.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            homepage hp = new homepage();
            hp.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            stations ss = new stations();
            ss.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            polices p = new polices();
            p.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            criminals c = new criminals();
            c.Show();
            this.Hide();

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

            this.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

            stationview sv = new stationview();
            sv.Show();
            this.Hide();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            policeview pv = new policeview();
            pv.Show();
            this.Hide();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            criminalview cv = new criminalview();
            cv.Show();
            this.Hide();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            firview fv = new firview();
            fv.Show();
            this.Hide();

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            contactus cu = new contactus();
            cu.Show();
            this.Hide();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

            fir fr = new fir();
            fr.Show();
            this.Hide();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            Firstpage f1 = new Firstpage();
            f1.Show();
            this.Hide();
        }
        }
    }

