namespace PJ_RE_MykhailoHnylytskyi
{
    partial class frmSalleGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboGameCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSelectCategory = new System.Windows.Forms.ComboBox();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.grpPurchaseDetails = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpExpiresDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardHolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.mnuAddCategory.SuspendLayout();
            this.grpPurchaseDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddCategory
            // 
            this.mnuAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuAddCategory.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuAddCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuAddCategory.Location = new System.Drawing.Point(457, 9);
            this.mnuAddCategory.Name = "mnuAddCategory";
            this.mnuAddCategory.Size = new System.Drawing.Size(90, 24);
            this.mnuAddCategory.TabIndex = 35;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Select Category";
            // 
            // cboGameCategory
            // 
            this.cboGameCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGameCategory.FormattingEnabled = true;
            this.cboGameCategory.Items.AddRange(new object[] {
            "FC",
            "AD ",
            "VR"});
            this.cboGameCategory.Location = new System.Drawing.Point(132, 43);
            this.cboGameCategory.Name = "cboGameCategory";
            this.cboGameCategory.Size = new System.Drawing.Size(48, 21);
            this.cboGameCategory.TabIndex = 36;
            this.cboGameCategory.SelectedIndexChanged += new System.EventHandler(this.cboGameCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Select Game";
            this.label2.Visible = false;
            // 
            // cboSelectCategory
            // 
            this.cboSelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectCategory.FormattingEnabled = true;
            this.cboSelectCategory.Items.AddRange(new object[] {
            "EA Sports FC 25 is a football simulator video game published by EA Sports.",
            "Red Dead Redemption 2 is an action-adventure game developed and published by Rock" +
                "star Games.",
            "Half-Life: Alyx is a virtual reality first-person shooter game developed and publ" +
                "ished by Valve."});
            this.cboSelectCategory.Location = new System.Drawing.Point(132, 81);
            this.cboSelectCategory.Name = "cboSelectCategory";
            this.cboSelectCategory.Size = new System.Drawing.Size(125, 21);
            this.cboSelectCategory.TabIndex = 38;
            this.cboSelectCategory.Visible = false;
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCart.ForeColor = System.Drawing.Color.Red;
            this.btnAddtoCart.Location = new System.Drawing.Point(111, 225);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(104, 48);
            this.btnAddtoCart.TabIndex = 40;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // grpPurchaseDetails
            // 
            this.grpPurchaseDetails.Controls.Add(this.label7);
            this.grpPurchaseDetails.Controls.Add(this.txtCVV);
            this.grpPurchaseDetails.Controls.Add(this.label6);
            this.grpPurchaseDetails.Controls.Add(this.dtpExpiresDate);
            this.grpPurchaseDetails.Controls.Add(this.label5);
            this.grpPurchaseDetails.Controls.Add(this.txtCardNumber);
            this.grpPurchaseDetails.Controls.Add(this.label3);
            this.grpPurchaseDetails.Controls.Add(this.txtCardHolder);
            this.grpPurchaseDetails.Controls.Add(this.label4);
            this.grpPurchaseDetails.Location = new System.Drawing.Point(290, 43);
            this.grpPurchaseDetails.Name = "grpPurchaseDetails";
            this.grpPurchaseDetails.Size = new System.Drawing.Size(232, 149);
            this.grpPurchaseDetails.TabIndex = 41;
            this.grpPurchaseDetails.TabStop = false;
            this.grpPurchaseDetails.Text = "Card Details";
            this.grpPurchaseDetails.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "CVV Code";
            // 
            // txtCVV
            // 
            this.txtCVV.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCVV.Location = new System.Drawing.Point(100, 109);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(36, 22);
            this.txtCVV.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(5, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Expires Date";
            // 
            // dtpExpiresDate
            // 
            this.dtpExpiresDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiresDate.Location = new System.Drawing.Point(100, 83);
            this.dtpExpiresDate.Name = "dtpExpiresDate";
            this.dtpExpiresDate.Size = new System.Drawing.Size(123, 20);
            this.dtpExpiresDate.TabIndex = 38;
            this.dtpExpiresDate.Value = new System.DateTime(2024, 11, 28, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-62, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Date of Birth";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCardNumber.Location = new System.Drawing.Point(100, 55);
            this.txtCardNumber.MaxLength = 16;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(123, 22);
            this.txtCardNumber.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(5, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Card Number";
            // 
            // txtCardHolder
            // 
            this.txtCardHolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardHolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCardHolder.Location = new System.Drawing.Point(100, 29);
            this.txtCardHolder.MaxLength = 45;
            this.txtCardHolder.Multiline = true;
            this.txtCardHolder.Name = "txtCardHolder";
            this.txtCardHolder.Size = new System.Drawing.Size(123, 20);
            this.txtCardHolder.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(5, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Card Holder";
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.Red;
            this.btnBuy.Location = new System.Drawing.Point(352, 225);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(104, 48);
            this.btnBuy.TabIndex = 42;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Visible = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // frmSalleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 295);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.grpPurchaseDetails);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSelectCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboGameCategory);
            this.Controls.Add(this.mnuAddCategory);
            this.Name = "frmSalleGame";
            this.Text = "Viter Game Store - [Salle Game]";
            this.mnuAddCategory.ResumeLayout(false);
            this.mnuAddCategory.PerformLayout();
            this.grpPurchaseDetails.ResumeLayout(false);
            this.grpPurchaseDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddCategory;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGameCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSelectCategory;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.GroupBox grpPurchaseDetails;
        private System.Windows.Forms.TextBox txtCardHolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpExpiresDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Button btnBuy;
    }
}