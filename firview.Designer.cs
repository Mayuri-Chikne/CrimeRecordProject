namespace crimeproject
{
    partial class firview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firview));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crimeprojectDataSet2 = new crimeproject.crimeprojectDataSet2();
            this.firTableAdapter = new crimeproject.crimeprojectDataSet2TableAdapters.firTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEPAGEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRIMINALMODULEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oWEFKFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOLICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRIMINALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTACTUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.firnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offencenatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copdealingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimeprojectDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(239, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1744, 204);
            this.label1.TabIndex = 9;
            this.label1.Text = "  \r\n      CRIME RECORD MANANGEMENT SYSTEM                         \r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(778, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 51);
            this.label2.TabIndex = 11;
            this.label2.Text = "FIR  Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firnoDataGridViewTextBoxColumn,
            this.firdateDataGridViewTextBoxColumn,
            this.stationnameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.offencenatureDataGridViewTextBoxColumn,
            this.copdealingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(628, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 275);
            this.dataGridView1.TabIndex = 12;
            // 
            // firBindingSource
            // 
            this.firBindingSource.DataMember = "fir";
            this.firBindingSource.DataSource = this.crimeprojectDataSet2;
            // 
            // crimeprojectDataSet2
            // 
            this.crimeprojectDataSet2.DataSetName = "crimeprojectDataSet2";
            this.crimeprojectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firTableAdapter
            // 
            this.firTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEPAGEToolStripMenuItem,
            this.aBOUTUSToolStripMenuItem,
            this.cRIMINALMODULEToolStripMenuItem,
            this.oWEFKFToolStripMenuItem,
            this.lOGOUTToolStripMenuItem,
            this.cONTACTUSToolStripMenuItem,
            this.lOGOUTToolStripMenuItem1,
            this.lOGOUTToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(235, 159);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1573, 42);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hOMEPAGEToolStripMenuItem
            // 
            this.hOMEPAGEToolStripMenuItem.Name = "hOMEPAGEToolStripMenuItem";
            this.hOMEPAGEToolStripMenuItem.Size = new System.Drawing.Size(193, 36);
            this.hOMEPAGEToolStripMenuItem.Text = "  HOME         ";
            this.hOMEPAGEToolStripMenuItem.Click += new System.EventHandler(this.hOMEPAGEToolStripMenuItem_Click);
            // 
            // aBOUTUSToolStripMenuItem
            // 
            this.aBOUTUSToolStripMenuItem.Name = "aBOUTUSToolStripMenuItem";
            this.aBOUTUSToolStripMenuItem.Size = new System.Drawing.Size(217, 36);
            this.aBOUTUSToolStripMenuItem.Text = "  STATION        ";
            this.aBOUTUSToolStripMenuItem.Click += new System.EventHandler(this.aBOUTUSToolStripMenuItem_Click);
            // 
            // cRIMINALMODULEToolStripMenuItem
            // 
            this.cRIMINALMODULEToolStripMenuItem.Name = "cRIMINALMODULEToolStripMenuItem";
            this.cRIMINALMODULEToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.cRIMINALMODULEToolStripMenuItem.Text = "POLICE      ";
            this.cRIMINALMODULEToolStripMenuItem.Click += new System.EventHandler(this.cRIMINALMODULEToolStripMenuItem_Click);
            // 
            // oWEFKFToolStripMenuItem
            // 
            this.oWEFKFToolStripMenuItem.Name = "oWEFKFToolStripMenuItem";
            this.oWEFKFToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.oWEFKFToolStripMenuItem.Text = "CRIMINAL      ";
            this.oWEFKFToolStripMenuItem.Click += new System.EventHandler(this.oWEFKFToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTATIONToolStripMenuItem,
            this.pOLICEToolStripMenuItem,
            this.cRIMINALToolStripMenuItem,
            this.fIRToolStripMenuItem});
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(179, 36);
            this.lOGOUTToolStripMenuItem.Text = "SEARCH     ";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // sTATIONToolStripMenuItem
            // 
            this.sTATIONToolStripMenuItem.Name = "sTATIONToolStripMenuItem";
            this.sTATIONToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.sTATIONToolStripMenuItem.Text = "STATION";
            this.sTATIONToolStripMenuItem.Click += new System.EventHandler(this.sTATIONToolStripMenuItem_Click);
            // 
            // pOLICEToolStripMenuItem
            // 
            this.pOLICEToolStripMenuItem.Name = "pOLICEToolStripMenuItem";
            this.pOLICEToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.pOLICEToolStripMenuItem.Text = "POLICE";
            this.pOLICEToolStripMenuItem.Click += new System.EventHandler(this.pOLICEToolStripMenuItem_Click);
            // 
            // cRIMINALToolStripMenuItem
            // 
            this.cRIMINALToolStripMenuItem.Name = "cRIMINALToolStripMenuItem";
            this.cRIMINALToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.cRIMINALToolStripMenuItem.Text = "CRIMINAL";
            this.cRIMINALToolStripMenuItem.Click += new System.EventHandler(this.cRIMINALToolStripMenuItem_Click);
            // 
            // fIRToolStripMenuItem
            // 
            this.fIRToolStripMenuItem.Name = "fIRToolStripMenuItem";
            this.fIRToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.fIRToolStripMenuItem.Text = "FIR";
            this.fIRToolStripMenuItem.Click += new System.EventHandler(this.fIRToolStripMenuItem_Click);
            // 
            // cONTACTUSToolStripMenuItem
            // 
            this.cONTACTUSToolStripMenuItem.Name = "cONTACTUSToolStripMenuItem";
            this.cONTACTUSToolStripMenuItem.Size = new System.Drawing.Size(240, 36);
            this.cONTACTUSToolStripMenuItem.Text = "CONTACT US     ";
            this.cONTACTUSToolStripMenuItem.Click += new System.EventHandler(this.cONTACTUSToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem1
            // 
            this.lOGOUTToolStripMenuItem1.Name = "lOGOUTToolStripMenuItem1";
            this.lOGOUTToolStripMenuItem1.Size = new System.Drawing.Size(117, 36);
            this.lOGOUTToolStripMenuItem1.Text = "FIR      ";
            this.lOGOUTToolStripMenuItem1.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem1_Click);
            // 
            // lOGOUTToolStripMenuItem2
            // 
            this.lOGOUTToolStripMenuItem2.Name = "lOGOUTToolStripMenuItem2";
            this.lOGOUTToolStripMenuItem2.Size = new System.Drawing.Size(226, 36);
            this.lOGOUTToolStripMenuItem2.Text = "LOG OUT          ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-7, 284);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-7, 526);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(291, 201);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(5, -3);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(226, 204);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // firnoDataGridViewTextBoxColumn
            // 
            this.firnoDataGridViewTextBoxColumn.DataPropertyName = "firno";
            this.firnoDataGridViewTextBoxColumn.HeaderText = "Fir Number";
            this.firnoDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.firnoDataGridViewTextBoxColumn.Name = "firnoDataGridViewTextBoxColumn";
            // 
            // firdateDataGridViewTextBoxColumn
            // 
            this.firdateDataGridViewTextBoxColumn.DataPropertyName = "firdate";
            this.firdateDataGridViewTextBoxColumn.HeaderText = "Fir Date";
            this.firdateDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.firdateDataGridViewTextBoxColumn.Name = "firdateDataGridViewTextBoxColumn";
            // 
            // stationnameDataGridViewTextBoxColumn
            // 
            this.stationnameDataGridViewTextBoxColumn.DataPropertyName = "stationname";
            this.stationnameDataGridViewTextBoxColumn.HeaderText = "Station Name";
            this.stationnameDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.stationnameDataGridViewTextBoxColumn.Name = "stationnameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // offencenatureDataGridViewTextBoxColumn
            // 
            this.offencenatureDataGridViewTextBoxColumn.DataPropertyName = "offencenature";
            this.offencenatureDataGridViewTextBoxColumn.HeaderText = "Offence Nature";
            this.offencenatureDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.offencenatureDataGridViewTextBoxColumn.Name = "offencenatureDataGridViewTextBoxColumn";
            // 
            // copdealingDataGridViewTextBoxColumn
            // 
            this.copdealingDataGridViewTextBoxColumn.DataPropertyName = "copdealing";
            this.copdealingDataGridViewTextBoxColumn.HeaderText = "Cop Dealing";
            this.copdealingDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.copdealingDataGridViewTextBoxColumn.Name = "copdealingDataGridViewTextBoxColumn";
            // 
            // firview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1682, 803);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1700, 850);
            this.Name = "firview";
            this.Text = "CRIME RECORD MANAGEMENT SYSTEM";
            this.Load += new System.EventHandler(this.firview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimeprojectDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private crimeprojectDataSet2 crimeprojectDataSet2;
        private System.Windows.Forms.BindingSource firBindingSource;
        private crimeprojectDataSet2TableAdapters.firTableAdapter firTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEPAGEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRIMINALMODULEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oWEFKFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOLICEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRIMINALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONTACTUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn firnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offencenatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copdealingDataGridViewTextBoxColumn;
    }
}