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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCategory nextForm = new frmAddCategory(this);
            nextForm.Show();
        }

        private void updateCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateCategory nextForm = new frmUpdateCategory(this);
            nextForm.Show();
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

        private void showYearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowYearlyRevenueAnalysis nextForm = new frmShowYearlyRevenueAnalysis(this);
            nextForm.Show();
        }

        private void addGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddGame nextForm = new frmAddGame(this);
            nextForm.Show();
        }

        private void updateGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateGame nextForm = new frmUpdateGame(this);
            nextForm.Show();
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddAccount nextForm = new frmAddAccount(this);
            nextForm.Show();
        }

        private void removeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveGame nextForm = new frmRemoveGame(this);
            nextForm.Show();
        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateAccount nextForm = new frmUpdateAccount(this);
            nextForm.Show();
        }

        private void closeAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCloseAccount nextForm = new frmCloseAccount(this);
            nextForm.Show();
        }

        private void sallGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalleGame nextForm = new frmSalleGame(this);
            nextForm.Show();
        }

        private void returnGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnGame nextForm = new frmReturnGame(this);
            nextForm.Show();
        }

        private void showGamesAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowGamesAnalysis nextForm = new frmShowGamesAnalysis(this);
            nextForm.Show();
        }

    }
}
