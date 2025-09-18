using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PJ_RE_MykhailoHnylytskyi
{
    public partial class frmSalleGame : Form
    {
        frmMainMenu parent;
        public frmSalleGame()
        {
            InitializeComponent();
        }
        public frmSalleGame(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (cboSelectCategory.SelectedIndex == -1)
            {
                MessageBox.Show("You need select the game", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (cboGameCategory.SelectedIndex == -1)
            {
                MessageBox.Show("You need select the category", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            DialogResult dialog = MessageBox.Show("Do you want more games?", "Confirm",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                cboSelectCategory.SelectedIndex = -1;
                cboGameCategory.SelectedIndex = -1;
                cboSelectCategory.Visible = false;
                label2.Visible = false;
                return;
            }
            else
            {
                MessageBox.Show("Thank you, transfer to the next step!", "Confirm",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
     

                cboSelectCategory.SelectedIndex = -1;
                cboGameCategory.SelectedIndex = -1;
                cboSelectCategory.Visible = false;
                label2.Visible = false;

                grpPurchaseDetails.Visible = true;
                btnBuy.Visible = true;

                
            }

        }

        private void cboGameCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           label2.Visible = true;
           cboSelectCategory.Visible = true;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);


            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (txtCardHolder.Text.Equals(""))
            {
                MessageBox.Show("Card Holder Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtCardHolder.Focus();

                return;
            }

            if (Int32.TryParse(txtCardHolder.Text, out int number))
            {
                MessageBox.Show("Card Holder Must not be numeric",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCardHolder.Clear();

                txtCardHolder.Focus();

                return;
            }

            if (string.IsNullOrEmpty(dtpExpiresDate.Text))
            {
                MessageBox.Show("Expires Date Must be selected", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                dtpExpiresDate.Focus();

                return;
            }



            if (txtCardNumber.Text.Equals(""))
            {
                MessageBox.Show("Card Number Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtCardNumber.Focus();

                return;
            }

            if (txtCardNumber.TextLength < 16)
            {
                MessageBox.Show("Card number Must be exactly 16 digits long",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCardNumber.Clear();

                txtCardNumber.Focus();

                return;
            }

            if (!long.TryParse(txtCardNumber.Text, out long cardNumber))
            {
                MessageBox.Show("Card number Must be numeric",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCardNumber.Clear();

                txtCardNumber.Focus();

                return;
            }

            if (txtCVV.Text.Equals(""))
            {
                MessageBox.Show("CVV Code Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtCVV.Focus();

                return;
            }

            if (!Int32.TryParse(txtCVV.Text, out int cvv))
            {
                MessageBox.Show("CVV Code Must be numeric",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCVV.Clear();

                txtCVV.Focus();

                return;
            }

            MessageBox.Show("Hope you enjoy our service!", "Confirm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCardHolder.Clear();
            txtCardNumber.Clear();
            txtCVV.Clear();

            grpPurchaseDetails.Visible = false;
            btnBuy.Visible = false;

        }
    }
}
