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
    public partial class frmUpdateCategory : Form
    {
        frmMainMenu parent;
        public frmUpdateCategory()
        {
            InitializeComponent();
        }
        public frmUpdateCategory(frmMainMenu parent)
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
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            //Check answer

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameCategory.Text))
            {
                MessageBox.Show("Category Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtNameCategory.Focus();

                return;
            }

            if (Int32.TryParse(txtNameCategory.Text, out int number))
            {
                MessageBox.Show("First Name Must not be numeric",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNameCategory.Clear();

                txtNameCategory.Focus();

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

            MessageBox.Show("Category Updated Successfully", "Success", MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            cboCategory.SelectedIndex = -1;
            grpCategory.Visible = false;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtNameCategory.Text = "RC";
            txtDescription.Text = "Race";
           

            grpCategory.Visible = true;

        }

    }
}
