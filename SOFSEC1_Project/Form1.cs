using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFSEC1_Project
{
    public partial class GPAware: Form
    {
        public GPAware()
        {
            InitializeComponent();
        }

        private void ShowPanel(Panel panelToShow)
        {
            // Hide all panels first DAGDAG SI GPATRACK
            CALCULATOR.Visible = false;
            HOME.Visible = false;
            DASHBOARD.Visible = false;
            SIGNUP.Visible = false;
            GPAVIEW.Visible = false;

            // Show the selected panel
            panelToShow.Visible = true;
        }



        private void GPACalculator_Click(object sender, EventArgs e)
        {
            ShowPanel(GPAVIEW);
        }

    }
}
