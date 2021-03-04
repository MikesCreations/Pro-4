using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Random generator = new Random();
        private void btnInt_Click(object sender, EventArgs e)
        {
            int Min, Max;

            if (!Int32.TryParse(txtMin.Text, out Min) || !Int32.TryParse(txtMax.Text, out Max))
                lblOutput.Text = "Write a number";
            
            else if (Min > Max)
                lblOutput.Text = "Error, min>max";

            else
                lblOutput.Text = generator.Next(Min, Max) + "";

            

            

        }

        private void btnDub_Click(object sender, EventArgs e)
        {
            int Min, Max;

            if (!Int32.TryParse(txtMin.Text, out Min) || !Int32.TryParse(txtMax.Text, out Max))
                lblOutput.Text = "Write a number";

            else if (Min > Max)
                lblOutput.Text = "Error, min>max";

            else                         
                lblOutput.Text = generator.Next(Min, Max) + generator.NextDouble() + "";
        }
    }
}
