using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_RE_MykhailoHnylytskyi
{
    public partial class frmAddGame : Form
    {
        frmMainMenu parent;
        public frmAddGame()
        {
            InitializeComponent();
        }

        public frmAddGame(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Name Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtName.Focus();

                return;
            }

            if (Int32.TryParse(txtName.Text, out int number))
            {
                MessageBox.Show("First Name Must not be numeric",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtName.Clear();

                txtName.Focus();

                return;
            }

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Description Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtDescription.Focus();

                return;
            }

            if (Int32.TryParse(txtDescription.Text, out int num))
            {
                MessageBox.Show("Description Must not be numeric",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDescription.Clear();

                txtDescription.Focus();

                return;
            }

            if (txtRate.Text.Equals("0.00") || txtRate.Text.Equals(""))
            {
                MessageBox.Show("Rate Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtRate.Clear();

                txtRate.Focus();

                return;
            }

            if (!Double.TryParse(txtRate.Text, out Double rate))
            {
                MessageBox.Show("Rate Must be numeric",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtRate.Clear();

                txtRate.Focus();

                return;
            }

            if (Convert.ToDouble(txtRate.Text) < 0)
            {
                MessageBox.Show("Rate Must be Greater than Zero", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtRate.Clear();

                txtRate.Focus();

                return;

            }

            if (cboGameCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Category Must be selected", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("Game Added Successfully", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset the UI

            txtName.Clear();
            txtDescription.Clear();
            txtRate.Text = "0.00";
            txtName.Focus();
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

            //Check answer

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
