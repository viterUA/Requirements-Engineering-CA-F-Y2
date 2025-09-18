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
    public partial class frmAddCategory : Form
    {
        frmMainMenu parent;
        public frmAddCategory()
        {
            InitializeComponent();
        }

        public frmAddCategory(frmMainMenu parent)
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

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

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

            MessageBox.Show("Category Added Successfully", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtNameCategory.Clear();
            txtDescription.Clear();
            txtNameCategory.Focus();
        }
    }
}
