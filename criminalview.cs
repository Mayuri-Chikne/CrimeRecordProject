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
    public partial class criminalview : Form
    {
        public criminalview()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void criminalview_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            // TODO: This line of code loads data into the 'crimeprojectDataSet5.criminals' table. You can move, or remove it, as needed.
            this.criminalsTableAdapter.Fill(this.crimeprojectDataSet5.criminals);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox4.Width - 3, pictureBox4.Height - 3);
            Region rg = new Region(gp);
            pictureBox4.Region = rg;// TODO: This line of code loads data into the 'crimeprojectDataSet3.criminal' table. You can move, or remove it, as needed.
           // this.criminalTableAdapter.Fill(this.crimeprojectDataSet3.criminal);

        }

        private void oWEFKFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hOMEPAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homepage hp = new homepage();
            hp.Show();
            this.Hide();
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stations ss = new stations();
            ss.Show();
            this.Hide();
        }

        private void cRIMINALMODULEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polices p = new polices();
            p.Show();
            this.Hide();
        }

        private void oWEFKFToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            foreach (DataGridViewRow x in dataGridView1.Rows)
            {
                x.MinimumHeight = 250;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
