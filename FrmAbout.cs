using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NumberConversionApp
{

 /*
 * FrmAbout.cs
 * Code for the about form
 * Created By: Shaun Trimm
 * Created On: 12-7-2020
 * Last Modified By: Shaun Trimm
 * Last Modified On: 12-11-2020
 * Assignment: A290 NET Individual Final Project Phase 3
 */
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        //Is called when btnAbout is clicked
        private void btnAboutExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
