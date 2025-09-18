namespace PJ_RE_MykhailoHnylytskyi
{
    partial class frmShowYearlyRevenueAnalysis
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.pic2024 = new System.Windows.Forms.PictureBox();
            this.pic2022 = new System.Windows.Forms.PictureBox();
            this.pic2023 = new System.Windows.Forms.PictureBox();
            this.mnuAddCategory = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pic2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2022)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2023)).BeginInit();
            this.mnuAddCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Year";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(136, 162);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 21);
            this.cboYear.TabIndex = 13;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // pic2024
            // 
            this.pic2024.Image = global::PJ_RE_MykhailoHnylytskyi.Properties.Resources._2024;
            this.pic2024.Location = new System.Drawing.Point(284, 124);
            this.pic2024.Name = "pic2024";
            this.pic2024.Size = new System.Drawing.Size(365, 208);
            this.pic2024.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2024.TabIndex = 14;
            this.pic2024.TabStop = false;
            this.pic2024.Visible = false;
            // 
            // pic2022
            // 
            this.pic2022.Image = global::PJ_RE_MykhailoHnylytskyi.Properties.Resources._2022;
            this.pic2022.Location = new System.Drawing.Point(284, 124);
            this.pic2022.Name = "pic2022";
            this.pic2022.Size = new System.Drawing.Size(365, 208);
            this.pic2022.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2022.TabIndex = 15;
            this.pic2022.TabStop = false;
            this.pic2022.Visible = false;
            // 
            // pic2023
            // 
            this.pic2023.Image = global::PJ_RE_MykhailoHnylytskyi.Properties.Resources._2023;
            this.pic2023.Location = new System.Drawing.Point(284, 124);
            this.pic2023.Name = "pic2023";
            this.pic2023.Size = new System.Drawing.Size(365, 208);
            this.pic2023.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2023.TabIndex = 16;
            this.pic2023.TabStop = false;
            this.pic2023.Visible = false;
            // 
            // mnuAddCategory
            // 
            this.mnuAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuAddCategory.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuAddCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuAddCategory.Location = new System.Drawing.Point(439, 9);
            this.mnuAddCategory.Name = "mnuAddCategory";
            this.mnuAddCategory.Size = new System.Drawing.Size(210, 24);
            this.mnuAddCategory.TabIndex = 22;
            this.mnuAddCategory.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmShowYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 428);
            this.Controls.Add(this.mnuAddCategory);
            this.Controls.Add(this.pic2024);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic2023);
            this.Controls.Add(this.pic2022);
            this.Name = "frmShowYearlyRevenueAnalysis";
            this.Text = "Viter Game Store - [Show Yearly Revenue Analysis]";
            this.Load += new System.EventHandler(this.frmShowYearlyRevenueAnalysis_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pic2024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2022)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2023)).EndInit();
            this.mnuAddCategory.ResumeLayout(false);
            this.mnuAddCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.PictureBox pic2024;
        private System.Windows.Forms.PictureBox pic2022;
        private System.Windows.Forms.PictureBox pic2023;
        private System.Windows.Forms.MenuStrip mnuAddCategory;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}