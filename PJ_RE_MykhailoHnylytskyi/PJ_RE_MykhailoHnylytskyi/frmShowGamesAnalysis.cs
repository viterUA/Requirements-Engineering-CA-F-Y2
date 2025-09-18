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
    public partial class frmShowGamesAnalysis : Form
    {
        frmMainMenu parent;
        public frmShowGamesAnalysis()
        {
            InitializeComponent();
        }

        public frmShowGamesAnalysis(frmMainMenu parent)
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

        public void loadYears()
        {

            int year = DateTime.Now.Year;
            for (int i = 0; i <= 4; i++)
            {
                cboYear.Items.Add(year.ToString());
                i++;
                year--;

            }
        }

        private void frmShowGamesAnalysis_Load(object sender, EventArgs e)
        {
            loadYears();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedIndex == 0)
            {
                picGame2024.Visible = true;
                picGame2023.Visible = false;
                picGame2022.Visible = false;
            }

            if (cboYear.SelectedIndex == 1)
            {
                picGame2023.Visible = true;
                picGame2024.Visible = false;
                picGame2022.Visible = false;
            }

            if (cboYear.SelectedIndex == 2)
            {
                picGame2022.Visible = true;
                picGame2023.Visible = false;
                picGame2024.Visible = false;
            }
        }
    }
}
