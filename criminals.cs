using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Drawing2D;

namespace crimeproject
{
    public partial class criminals : Form
    {
        public criminals()
        {
            InitializeComponent();
        }
        string ptn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91830\Documents\Visual Studio 2010\Projects\crimeproject\crimeproject\crimeproject.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        string img1="";
        SqlCommand cmd;


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void oWEFKFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { OpenFileDialog op = new OpenFileDialog();
            op.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            string a = op.Filter;
            if (op.ShowDialog() == DialogResult.OK)
            { img1 = op.FileName.ToString();
            criminalphoto.ImageLocation = img1;
         //   textBox3.Text = img1;
            } 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91830\Documents\Visual Studio 2010\Projects\crimeproject\crimeproject\crimeproject.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into criminal values(" + cidtextbox.Text + ",'" + criminalnametextbox.Text + "','" + criminalphoto.ToString()+ "'," + agetextbox.Text + ",'" + gendertextbox.Text + "','" + offencetextbox.Text+ "','" + offencedatetextbox.Text + "','"+addresstextbox.Text+"','"+phonenotextbox.Text+"')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Sucessfully");*/
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

        private void criminal_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox4.Width - 3, pictureBox4.Height - 3);
            Region rg = new Region(gp);
            pictureBox4.Region = rg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
/*SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91830\Documents\Visual Studio 2010\Projects\crimeproject\crimeproject\crimeproject.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into criminal values(" + cidtextbox.Text + ",'" + criminalnametextbox.Text + "','" + criminalphoto.ToString() + "'," + agetextbox.Text + ",'" + gendertextbox.Text + "','" + offencetextbox.Text + "','" + offencedatetextbox.Text + "','" + addresstextbox.Text + "','" + phonenotextbox.Text + "')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Sucessfully");*/
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                FileStream st = new FileStream(img1, FileMode.Open, FileAccess.Read);
                BinaryReader be = new BinaryReader(st);
                images = be.ReadBytes((int)st.Length);
                string sqlquery = "insert into criminals(criminalid,criminalname,age,gender,offence,offencedate,address,phoneno,photo)values("+cidtextbox.Text+",'"+criminalnametextbox.Text+"',"+agetextbox.Text+",'"+gendertextbox.Text+"','"+offencetextbox.Text+"','"+criminaldateTimePicker.Text+"','"+addresstextbox.Text+"','"+phonenotextbox.Text+"',@images)";
                SqlConnection cn = new SqlConnection(ptn);
                cn.Open();
                cmd = new SqlCommand(sqlquery, cn);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int n = cmd.ExecuteNonQuery();
               // cn.Close();
                MessageBox.Show(n.ToString() + "data saved...");
               cidtextbox.Text="";
               criminalnametextbox.Text="";     
                agetextbox.Text="";    
               gendertextbox.Text=""; 
             offencetextbox.Text=""; 
           //  criminaldateTimePicker.Text=""; 
                addresstextbox.Text=""; 
              phonenotextbox.Text=""; 
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            
            }

        private void criminal_Load_1(object sender, EventArgs e)
        {
            
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox4.Width - 3, pictureBox4.Height - 3);
            Region rg = new Region(gp);
            pictureBox4.Region = rg;
        }

        private void sTATIONToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            stationview sv = new stationview();
            sv.Show();
            this.Hide();
        }

        private void pOLICEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            policeview pv = new policeview();
            pv.Show();
            this.Hide();
        }

        private void cRIMINALToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            criminalview cv = new criminalview();
            cv.Show();
            this.Hide();
        }

        private void fIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            firview fv = new firview();
            fv.Show();
            this.Hide();
        }

        private void cONTACTUSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            contactus cu = new contactus();
            cu.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            fir fr = new fir();
            fr.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            Firstpage f1 = new Firstpage();
            f1.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
        }

        private void oWEFKFToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            criminals c = new criminals();
            c.Show();
            this.Hide();
        }

        private void hOMEPAGEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            homepage hp = new homepage();
            hp.Show();
            this.Hide();
        }

        private void aBOUTUSToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

      
        }
    }

