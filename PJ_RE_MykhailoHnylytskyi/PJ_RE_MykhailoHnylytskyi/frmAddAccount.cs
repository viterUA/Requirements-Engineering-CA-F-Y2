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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PJ_RE_MykhailoHnylytskyi
{
    public partial class frmAddAccount : Form
    {
        frmMainMenu parent;
        public frmAddAccount()
        {
            InitializeComponent();
        }
        public frmAddAccount(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals(""))
            {
                MessageBox.Show("First Name Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtFirstName.Focus();

                return;
            }

            if (Int32.TryParse(txtFirstName.Text, out int number))
            {
                MessageBox.Show("First Name Must not be numeric",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtFirstName.Clear();

                txtFirstName.Focus();

                return;
            }

            if (txtLastName.Text.Equals(""))
            {
                MessageBox.Show("Last Name Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtLastName.Focus();

                return;
            }

            if (Int32.TryParse(txtLastName.Text, out int num))
            {
                MessageBox.Show("Last Name Must not be numeric",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtLastName.Clear();

                txtLastName.Focus();

                return;
            }

            if (string.IsNullOrEmpty(dtpDOB.Text))
            {
                MessageBox.Show("Date of Birth Must be selected", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                dtpDOB.Focus();

                return;
            }



            if (txtPhoneNO.Text.Equals(""))
            {
                MessageBox.Show("Phone Number Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtPhoneNO.Focus();

                return;
            }

            if (!Int32.TryParse(txtPhoneNO.Text, out int phone))
            {
                MessageBox.Show("Phone number Must be numeric",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPhoneNO.Clear();

                txtPhoneNO.Focus();

                return ;
            }

            if (txtEmail.Text.Equals("") || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Invalid email format.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtEmail.Clear();

                txtEmail.Focus();

                return;
            }

            MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset the UI

            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNO.Clear();
            txtEmail.Clear();
            txtFirstName.Focus();
        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
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
    }
    
}
