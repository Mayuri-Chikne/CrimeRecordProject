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
    public partial class stationview : Form
    {
        public stationview()
        {
            InitializeComponent();
        }

        private void stationview_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            // TODO: This line of code loads data into the 'crimeprojectDataSet6.stations' table. You can move, or remove it, as needed.
            this.stationsTableAdapter1.Fill(this.crimeprojectDataSet6.stations);
            // TODO: This line of code loads data into the 'crimeprojectDataSet4.stations' table. You can move, or remove it, as needed.
            this.stationsTableAdapter.Fill(this.crimeprojectDataSet4.stations);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox4.Width - 3, pictureBox4.Height - 3);
            Region rg = new Region(gp);
            pictureBox4.Region = rg;// TODO: This line of code loads data into the 'crimeprojectDataSet.station' table. You can move, or remove it, as needed.
            //this.stationTableAdapter.Fill(this.crimeprojectDataSet.station);

        }

        private void cRIMINALMODULEToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cRIMINALMODULEToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
