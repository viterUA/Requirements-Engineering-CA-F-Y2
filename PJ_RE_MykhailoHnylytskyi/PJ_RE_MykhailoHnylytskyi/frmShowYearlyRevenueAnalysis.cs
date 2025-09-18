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
    public partial class frmShowYearlyRevenueAnalysis : Form
    {
        frmMainMenu parent;
        public frmShowYearlyRevenueAnalysis()
        {
            InitializeComponent();
        }

        public frmShowYearlyRevenueAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }



        public void loadYears()
        {

            int year = 2024;
            for (int i = 0; i <= 4; i++)
            {
                cboYear.Items.Add(year.ToString());
                i++;
                year--;

            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedIndex == 0)
            {
                pic2024.Visible = true;
                pic2023.Visible = false;
                pic2022.Visible = false;
            }

            if (cboYear.SelectedIndex == 1)
            {
                pic2023.Visible = true;
                pic2024.Visible = false;
                pic2022.Visible = false;
            }

            if (cboYear.SelectedIndex == 2)
            {
                pic2022.Visible = true;
                pic2023.Visible = false;
                pic2024.Visible = false;
            }



        }

        private void frmShowYearlyRevenueAnalysis_Load_1(object sender, EventArgs e)
        {
            loadYears();
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
