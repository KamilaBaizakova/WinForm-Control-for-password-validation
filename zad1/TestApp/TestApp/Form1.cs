using System;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            pBar1.Maximum = 100;
            // Set the initial value of the ProgressBar.
            pBar1.Value = 0;
            // Set the Step property to a value of 1 to represent each file being copied.
            pBar1.Step = 33;
            userControl11.PasswordStrong += new EventHandler(ProgressBar_100Percent);
            userControl11.PasswordValid += new EventHandler(ProgressBar_PasswordValid);
            userControl11.OneRequirementSatisfied += new EventHandler(ProgressBar_OneRequirementSatisfied);
            userControl11.NoRequirementSatisfied += new EventHandler(ProgressBar_NoRequirementSatisfied);
        }
        public void ProgressBar_100Percent(object sender, EventArgs e)
        {
            pBar1.Value = 100;
        }

        public void ProgressBar_PasswordValid(object sender, EventArgs e)
        {
            pBar1.Value = 66;
        }
        public void ProgressBar_OneRequirementSatisfied(object sender, EventArgs e)
        {
            pBar1.Value = 33;
        }
        public void ProgressBar_NoRequirementSatisfied(object sender, EventArgs e)
        {
            pBar1.Value = 0;
        }
    }
}
