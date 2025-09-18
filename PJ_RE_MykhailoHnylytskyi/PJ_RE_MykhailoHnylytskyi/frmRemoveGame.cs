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

namespace PJ_RE_MykhailoHnylytskyi
{
    public partial class frmRemoveGame : Form
    {
        frmMainMenu parent;
        public frmRemoveGame()
        {
            InitializeComponent();
        }
        public frmRemoveGame(frmMainMenu parent)
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

        }

        private void btnRemoveGame_Click(object sender, EventArgs e)
        {
            if (txtGameID.Text.Equals(""))
            {
                MessageBox.Show("Game ID Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtGameID.Focus();

                return;
            }

            if (!Int32.TryParse(txtGameID.Text, out int num))
            {
                MessageBox.Show("Game ID Must not be numeric",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtGameID.Focus();

                return;
            }

            if (txtStatus.Text.Equals(""))
            {
                MessageBox.Show("Status Must be entered", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtStatus.Focus();

                return;
            }

            if (!txtStatus.Text.Equals("U"))
            {
                MessageBox.Show("Status Must be change to \"U\" - Unavailable", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtStatus.Clear();

                txtStatus.Focus();

                return;
            }

            MessageBox.Show("Game Removed Successfully", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            grpRemoveGame.Visible = false;

            txtGameID.Clear();
            txtStatus.Clear();
            txtRate.Clear();
            txtCategory.Clear();
            txtStatus.Clear();
            txtGameID.Focus();

            
        }

        private void txtGameID_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtGameID.Text, out int num))
            {
                txtName.Text = "EA FC 25";
                txtCategory.Text = "SM";
                txtDescription.Text = "Footbal Simulator";
                txtRate.Text = "75";
                txtStatus.Text = "A";


                grpRemoveGame.Visible = true;
                btnRemoveGame.Visible = true;
            }
        }
    }
}

