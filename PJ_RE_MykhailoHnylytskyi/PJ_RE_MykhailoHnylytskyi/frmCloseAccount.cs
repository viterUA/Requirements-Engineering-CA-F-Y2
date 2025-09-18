using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PJ_RE_MykhailoHnylytskyi
{
    public partial class frmCloseAccount : Form
    {
        frmMainMenu parent;
        public frmCloseAccount()
        {
            InitializeComponent();
        }

        public frmCloseAccount(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;  
        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {


            if (txtStatus.Text.Equals(""))
            {
                MessageBox.Show("Status Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtStatus.Focus();

                return;
            }

            if (!txtStatus.Text.Equals("C"))
            {
                MessageBox.Show("Status Must be change to \"C\" - Close", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtStatus.Clear();

                txtStatus.Focus();

                return;
            }


            MessageBox.Show("Account Removed Successfuly", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset the UI

            txtAccountID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDOB.Clear();
            txtPhoneNO.Clear();
            txtEmail.Clear();
            txtAccountID.Focus();

            btnCloseAccount.Visible = false;
            grpAccount.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            //Check answer

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void txtAccountID_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtAccountID.Text, out int num))
            {
                txtFirstName.Text = "Ryan";
                txtLastName.Text = "Gosling";
                txtDOB.Text = "12-November-1980";
                txtPhoneNO.Text = "353852878467";
                txtEmail.Text = "ryan.golsing@superstar.sigma";
                txtStatus.Text = "A";


                grpAccount.Visible = true;
                btnCloseAccount.Visible = true;
            }
        }
    }
}
