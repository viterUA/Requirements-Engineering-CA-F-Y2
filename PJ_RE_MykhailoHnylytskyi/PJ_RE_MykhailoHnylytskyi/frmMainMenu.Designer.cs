using System;

namespace PJ_RE_MykhailoHnylytskyi
{
    partial class frmMainMenu
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
            this.picMainMenu = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sallGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showYearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGamesAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMainMenu
            // 
            this.picMainMenu.Image = global::PJ_RE_MykhailoHnylytskyi.Properties.Resources.my_logo;
            this.picMainMenu.Location = new System.Drawing.Point(143, -19);
            this.picMainMenu.Name = "picMainMenu";
            this.picMainMenu.Size = new System.Drawing.Size(616, 357);
            this.picMainMenu.TabIndex = 0;
            this.picMainMenu.TabStop = false;
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripMenuItem,
            this.updateCategoryToolStripMenuItem,
            this.addGameToolStripMenuItem,
            this.updateGameToolStripMenuItem,
            this.removeGameToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addCategoryToolStripMenuItem.Text = "Add Category";
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // updateCategoryToolStripMenuItem
            // 
            this.updateCategoryToolStripMenuItem.Name = "updateCategoryToolStripMenuItem";
            this.updateCategoryToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.updateCategoryToolStripMenuItem.Text = "Update Category";
            this.updateCategoryToolStripMenuItem.Click += new System.EventHandler(this.updateCategoryToolStripMenuItem_Click);
            // 
            // addGameToolStripMenuItem
            // 
            this.addGameToolStripMenuItem.Name = "addGameToolStripMenuItem";
            this.addGameToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addGameToolStripMenuItem.Text = "Add Game";
            this.addGameToolStripMenuItem.Click += new System.EventHandler(this.addGameToolStripMenuItem_Click);
            // 
            // updateGameToolStripMenuItem
            // 
            this.updateGameToolStripMenuItem.Name = "updateGameToolStripMenuItem";
            this.updateGameToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.updateGameToolStripMenuItem.Text = "Update Game";
            this.updateGameToolStripMenuItem.Click += new System.EventHandler(this.updateGameToolStripMenuItem_Click);
            // 
            // removeGameToolStripMenuItem
            // 
            this.removeGameToolStripMenuItem.Name = "removeGameToolStripMenuItem";
            this.removeGameToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.removeGameToolStripMenuItem.Text = "Remove Game";
            this.removeGameToolStripMenuItem.Click += new System.EventHandler(this.removeGameToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.updateAccountToolStripMenuItem,
            this.closeAccountsToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountsToolStripMenuItem.Text = "Account";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addAccountToolStripMenuItem.Text = "Add Account";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
            // 
            // updateAccountToolStripMenuItem
            // 
            this.updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateAccountToolStripMenuItem.Text = "Update Account";
            this.updateAccountToolStripMenuItem.Click += new System.EventHandler(this.updateAccountToolStripMenuItem_Click);
            // 
            // closeAccountsToolStripMenuItem
            // 
            this.closeAccountsToolStripMenuItem.Name = "closeAccountsToolStripMenuItem";
            this.closeAccountsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.closeAccountsToolStripMenuItem.Text = "Close Account";
            this.closeAccountsToolStripMenuItem.Click += new System.EventHandler(this.closeAccountsToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sallGameToolStripMenuItem,
            this.returnGameToolStripMenuItem});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.saleToolStripMenuItem.Text = "Sale";
            // 
            // sallGameToolStripMenuItem
            // 
            this.sallGameToolStripMenuItem.Name = "sallGameToolStripMenuItem";
            this.sallGameToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sallGameToolStripMenuItem.Text = "Sall Game";
            this.sallGameToolStripMenuItem.Click += new System.EventHandler(this.sallGameToolStripMenuItem_Click);
            // 
            // returnGameToolStripMenuItem
            // 
            this.returnGameToolStripMenuItem.Name = "returnGameToolStripMenuItem";
            this.returnGameToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.returnGameToolStripMenuItem.Text = "Return Game";
            this.returnGameToolStripMenuItem.Click += new System.EventHandler(this.returnGameToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showYearlyRevenueAnalysisToolStripMenuItem,
            this.showGamesAnalysisToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // showYearlyRevenueAnalysisToolStripMenuItem
            // 
            this.showYearlyRevenueAnalysisToolStripMenuItem.Name = "showYearlyRevenueAnalysisToolStripMenuItem";
            this.showYearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.showYearlyRevenueAnalysisToolStripMenuItem.Text = "Show Yearly Revenue Analysis";
            this.showYearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.showYearlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // showGamesAnalysisToolStripMenuItem
            // 
            this.showGamesAnalysisToolStripMenuItem.Name = "showGamesAnalysisToolStripMenuItem";
            this.showGamesAnalysisToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.showGamesAnalysisToolStripMenuItem.Text = "Show Games Analysis";
            this.showGamesAnalysisToolStripMenuItem.Click += new System.EventHandler(this.showGamesAnalysisToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.picMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "Viter Game Store - [Main Menu]";
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

  

        #endregion

        private System.Windows.Forms.PictureBox picMainMenu;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showYearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGamesAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sallGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnGameToolStripMenuItem;
    }
}