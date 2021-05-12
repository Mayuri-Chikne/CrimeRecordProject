namespace crimeproject
{
    partial class policeview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(policeview));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.policeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationinchargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crimeprojectDataSet1 = new crimeproject.crimeprojectDataSet1();
            this.policeTableAdapter = new crimeproject.crimeprojectDataSet1TableAdapters.policeTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimeprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(230, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1744, 204);
            this.label1.TabIndex = 8;
            this.label1.Text = "  \r\n      CRIME RECORD MANANGEMENT SYSTEM                         \r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(742, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 49);
            this.label2.TabIndex = 10;
            this.label2.Text = "Police  Information";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.policeidDataGridViewTextBoxColumn,
            this.policenameDataGridViewTextBoxColumn,
            this.stationinchargeDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phonenoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.policeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(539, 335);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 356);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // policeidDataGridViewTextBoxColumn
            // 
            this.policeidDataGridViewTextBoxColumn.DataPropertyName = "policeid";
            this.policeidDataGridViewTextBoxColumn.HeaderText = "Police ID";
            this.policeidDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.policeidDataGridViewTextBoxColumn.Name = "policeidDataGridViewTextBoxColumn";
            // 
            // policenameDataGridViewTextBoxColumn
            // 
            this.policenameDataGridViewTextBoxColumn.DataPropertyName = "policename";
            this.policenameDataGridViewTextBoxColumn.HeaderText = "Police  Name";
            this.policenameDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.policenameDataGridViewTextBoxColumn.Name = "policenameDataGridViewTextBoxColumn";
            // 
            // stationinchargeDataGridViewTextBoxColumn
            // 
            this.stationinchargeDataGridViewTextBoxColumn.DataPropertyName = "stationincharge";
            this.stationinchargeDataGridViewTextBoxColumn.HeaderText = "Station Incharge";
            this.stationinchargeDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.stationinchargeDataGridViewTextBoxColumn.Name = "stationinchargeDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "dateofbirth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dateofbirthDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Post";
            this.postDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phonenoDataGridViewTextBoxColumn
            // 
            this.phonenoDataGridViewTextBoxColumn.DataPropertyName = "phoneno";
            this.phonenoDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phonenoDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.phonenoDataGridViewTextBoxColumn.Name = "phonenoDataGridViewTextBoxColumn";
            // 
            // policeBindingSource
            // 
            this.policeBindingSource.DataMember = "police";
            this.policeBindingSource.DataSource = this.crimeprojectDataSet1;
            // 
            // crimeprojectDataSet1
            // 
            this.crimeprojectDataSet1.DataSetName = "crimeprojectDataSet1";
            this.crimeprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // policeTableAdapter
            // 
            this.policeTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, 292);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
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
            this.menuStrip1.Location = new System.Drawing.Point(226, 162);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1575, 42);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hOMEPAGEToolStripMenuItem
            // 
            this.hOMEPAGEToolStripMenuItem.Name = "hOMEPAGEToolStripMenuItem";
            this.hOMEPAGEToolStripMenuItem.Size = new System.Drawing.Size(193, 36);
            this.hOMEPAGEToolStripMenuItem.Text = "  HOME         ";
            this.hOMEPAGEToolStripMenuItem.Click += new System.EventHandler(this.hOMEPAGEToolStripMenuItem_Click_1);
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
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-4, 546);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(346, 246);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(226, 204);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // policeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1682, 803);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1700, 850);
            this.Name = "policeview";
            this.Text = "CRIME RECORD MANAGEMENT SYSTEM";
            this.Load += new System.EventHandler(this.policeview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimeprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private crimeprojectDataSet1 crimeprojectDataSet1;
        private System.Windows.Forms.BindingSource policeBindingSource;
        private crimeprojectDataSet1TableAdapters.policeTableAdapter policeTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn policeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationinchargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenoDataGridViewTextBoxColumn;
    }
}