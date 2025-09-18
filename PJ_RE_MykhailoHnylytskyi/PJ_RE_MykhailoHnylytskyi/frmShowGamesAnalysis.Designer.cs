namespace PJ_RE_MykhailoHnylytskyi
{
    partial class frmShowGamesAnalysis
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
            this.mnuAddCategory = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picGame2024 = new System.Windows.Forms.PictureBox();
            this.picGame2023 = new System.Windows.Forms.PictureBox();
            this.picGame2022 = new System.Windows.Forms.PictureBox();
            this.mnuAddCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGame2024)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame2023)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame2022)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuAddCategory
            // 
            this.mnuAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuAddCategory.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuAddCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuAddCategory.Location = new System.Drawing.Point(575, 9);
            this.mnuAddCategory.Name = "mnuAddCategory";
            this.mnuAddCategory.Size = new System.Drawing.Size(90, 24);
            this.mnuAddCategory.TabIndex = 26;
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
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(127, 162);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 21);
            this.cboYear.TabIndex = 24;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Select Year";
            // 
            // picGame2024
            // 
            this.picGame2024.Image = global::PJ_RE_MykhailoHnylytskyi.Properties.Resources.game2024;
            this.picGame2024.Location = new System.Drawing.Point(272, 111);
            this.picGame2024.Name = "picGame2024";
            this.picGame2024.Size = new System.Drawing.Size(365, 208);
            this.picGame2024.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGame2024.TabIndex = 25;
            this.picGame2024.TabStop = false;
            this.picGame2024.Visible = false;
            // 
            // picGame2023
            // 
            this.picGame2023.Image = global::PJ_RE_MykhailoHnylytskyi.Properties.Resources.game2023;
            this.picGame2023.Location = new System.Drawing.Point(272, 111);
            this.picGame2023.Name = "picGame2023";
            this.picGame2023.Size = new System.Drawing.Size(365, 208);
            this.picGame2023.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGame2023.TabIndex = 27;
            this.picGame2023.TabStop = false;
            this.picGame2023.Visible = false;
            // 
            // picGame2022
            // 
            this.picGame2022.Image = global::PJ_RE_MykhailoHnylytskyi.Properties.Resources.game2022;
            this.picGame2022.Location = new System.Drawing.Point(272, 111);
            this.picGame2022.Name = "picGame2022";
            this.picGame2022.Size = new System.Drawing.Size(365, 208);
            this.picGame2022.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGame2022.TabIndex = 28;
            this.picGame2022.TabStop = false;
            this.picGame2022.Visible = false;
            // 
            // frmShowGamesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 424);
            this.Controls.Add(this.mnuAddCategory);
            this.Controls.Add(this.picGame2024);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picGame2023);
            this.Controls.Add(this.picGame2022);
            this.Name = "frmShowGamesAnalysis";
            this.Text = "frmshowGamesAnalysis";
            this.Load += new System.EventHandler(this.frmShowGamesAnalysis_Load);
            this.mnuAddCategory.ResumeLayout(false);
            this.mnuAddCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGame2024)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame2023)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame2022)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddCategory;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox picGame2024;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picGame2023;
        private System.Windows.Forms.PictureBox picGame2022;
    }
}