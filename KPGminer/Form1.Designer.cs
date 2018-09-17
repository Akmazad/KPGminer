namespace KPGminer
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGetGenes = new System.Windows.Forms.Button();
            this.btnBatchExclusion = new System.Windows.Forms.Button();
            this.btnSingleExclusion = new System.Windows.Forms.Button();
            this.btnBatchInclusion = new System.Windows.Forms.Button();
            this.btnSingleInclusion = new System.Windows.Forms.Button();
            this.lboxSelected = new System.Windows.Forms.ListBox();
            this.lbxAll = new System.Windows.Forms.ListBox();
            this.lblSelectedPathways = new System.Windows.Forms.Label();
            this.lblChosePathwayFrom = new System.Windows.Forms.Label();
            this.comBoxOrganism = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog_OutputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 581);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(435, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 576);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(490, 574);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnGetGenes);
            this.panel2.Controls.Add(this.btnBatchExclusion);
            this.panel2.Controls.Add(this.btnSingleExclusion);
            this.panel2.Controls.Add(this.btnBatchInclusion);
            this.panel2.Controls.Add(this.btnSingleInclusion);
            this.panel2.Controls.Add(this.lboxSelected);
            this.panel2.Controls.Add(this.lbxAll);
            this.panel2.Controls.Add(this.lblSelectedPathways);
            this.panel2.Controls.Add(this.lblChosePathwayFrom);
            this.panel2.Controls.Add(this.comBoxOrganism);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 576);
            this.panel2.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(242, 514);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(141, 32);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Browse output directory";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnGetGenes
            // 
            this.btnGetGenes.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetGenes.Location = new System.Drawing.Point(55, 514);
            this.btnGetGenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetGenes.Name = "btnGetGenes";
            this.btnGetGenes.Size = new System.Drawing.Size(128, 32);
            this.btnGetGenes.TabIndex = 5;
            this.btnGetGenes.Text = "Get Pathway Genes";
            this.btnGetGenes.UseVisualStyleBackColor = true;
            this.btnGetGenes.Click += new System.EventHandler(this.btnGetGenes_Click);
            // 
            // btnBatchExclusion
            // 
            this.btnBatchExclusion.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchExclusion.Location = new System.Drawing.Point(193, 343);
            this.btnBatchExclusion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBatchExclusion.Name = "btnBatchExclusion";
            this.btnBatchExclusion.Size = new System.Drawing.Size(39, 25);
            this.btnBatchExclusion.TabIndex = 4;
            this.btnBatchExclusion.Text = "<<";
            this.btnBatchExclusion.UseVisualStyleBackColor = true;
            this.btnBatchExclusion.Click += new System.EventHandler(this.btnBatchExclusion_Click);
            // 
            // btnSingleExclusion
            // 
            this.btnSingleExclusion.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleExclusion.Location = new System.Drawing.Point(200, 292);
            this.btnSingleExclusion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSingleExclusion.Name = "btnSingleExclusion";
            this.btnSingleExclusion.Size = new System.Drawing.Size(26, 25);
            this.btnSingleExclusion.TabIndex = 4;
            this.btnSingleExclusion.Text = "<";
            this.btnSingleExclusion.UseVisualStyleBackColor = true;
            this.btnSingleExclusion.Click += new System.EventHandler(this.btnSingleExclusion_Click);
            // 
            // btnBatchInclusion
            // 
            this.btnBatchInclusion.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchInclusion.Location = new System.Drawing.Point(194, 249);
            this.btnBatchInclusion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBatchInclusion.Name = "btnBatchInclusion";
            this.btnBatchInclusion.Size = new System.Drawing.Size(38, 25);
            this.btnBatchInclusion.TabIndex = 4;
            this.btnBatchInclusion.Text = ">>";
            this.btnBatchInclusion.UseVisualStyleBackColor = true;
            this.btnBatchInclusion.Click += new System.EventHandler(this.btnBatchInclusion_Click);
            // 
            // btnSingleInclusion
            // 
            this.btnSingleInclusion.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleInclusion.Location = new System.Drawing.Point(200, 205);
            this.btnSingleInclusion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSingleInclusion.Name = "btnSingleInclusion";
            this.btnSingleInclusion.Size = new System.Drawing.Size(26, 25);
            this.btnSingleInclusion.TabIndex = 4;
            this.btnSingleInclusion.Text = ">";
            this.btnSingleInclusion.UseVisualStyleBackColor = true;
            this.btnSingleInclusion.Click += new System.EventHandler(this.btnSingleInclusion_Click);
            // 
            // lboxSelected
            // 
            this.lboxSelected.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxSelected.FormattingEnabled = true;
            this.lboxSelected.ItemHeight = 12;
            this.lboxSelected.Location = new System.Drawing.Point(242, 103);
            this.lboxSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lboxSelected.Name = "lboxSelected";
            this.lboxSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxSelected.Size = new System.Drawing.Size(176, 352);
            this.lboxSelected.TabIndex = 3;
            // 
            // lbxAll
            // 
            this.lbxAll.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAll.FormattingEnabled = true;
            this.lbxAll.ItemHeight = 12;
            this.lbxAll.Location = new System.Drawing.Point(8, 103);
            this.lbxAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxAll.Name = "lbxAll";
            this.lbxAll.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxAll.Size = new System.Drawing.Size(176, 352);
            this.lbxAll.TabIndex = 3;
            // 
            // lblSelectedPathways
            // 
            this.lblSelectedPathways.AutoSize = true;
            this.lblSelectedPathways.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedPathways.Location = new System.Drawing.Point(240, 80);
            this.lblSelectedPathways.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedPathways.Name = "lblSelectedPathways";
            this.lblSelectedPathways.Size = new System.Drawing.Size(119, 13);
            this.lblSelectedPathways.TabIndex = 2;
            this.lblSelectedPathways.Text = "Selected Pathway(s): 0";
            // 
            // lblChosePathwayFrom
            // 
            this.lblChosePathwayFrom.AutoSize = true;
            this.lblChosePathwayFrom.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChosePathwayFrom.Location = new System.Drawing.Point(5, 80);
            this.lblChosePathwayFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChosePathwayFrom.Name = "lblChosePathwayFrom";
            this.lblChosePathwayFrom.Size = new System.Drawing.Size(129, 13);
            this.lblChosePathwayFrom.TabIndex = 2;
            this.lblChosePathwayFrom.Text = "Chose from 0 pathway(s)";
            // 
            // comBoxOrganism
            // 
            this.comBoxOrganism.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxOrganism.FormattingEnabled = true;
            this.comBoxOrganism.Location = new System.Drawing.Point(8, 32);
            this.comBoxOrganism.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comBoxOrganism.Name = "comBoxOrganism";
            this.comBoxOrganism.Size = new System.Drawing.Size(410, 20);
            this.comBoxOrganism.TabIndex = 1;
            this.comBoxOrganism.SelectionChangeCommitted += new System.EventHandler(this.comBoxOrganism_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chose Organism";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(940, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 629);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "KPGminer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.ComboBox comBoxOrganism;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnBatchExclusion;
        private System.Windows.Forms.Button btnSingleExclusion;
        private System.Windows.Forms.Button btnBatchInclusion;
        private System.Windows.Forms.Button btnSingleInclusion;
        private System.Windows.Forms.ListBox lboxSelected;
        private System.Windows.Forms.ListBox lbxAll;
        private System.Windows.Forms.Label lblSelectedPathways;
        private System.Windows.Forms.Label lblChosePathwayFrom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_OutputDir;
        public System.Windows.Forms.Button btnGetGenes;
    }
}

