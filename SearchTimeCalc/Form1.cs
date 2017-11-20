using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchTimeCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            outLabel.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // on click, check if input is an int, then make the call to calculate and output to a label
            int recordsInput;
            if (int.TryParse(txtInput.Text, out recordsInput))
            {
                NumberOfSearches(recordsInput, outLabel);
                outLabel.Visible = true;
            }
            else
                MessageBox.Show("Please enter a valid number");
                  

                

        }

        private void NumberOfSearches(int records, Label label)
        {
            // number of searches is euqal to Log2(x); where x is the number of records
            int searches = Convert.ToInt32(Math.Log(records, 2));
            label.Text = string.Format("{0} searches at the most to find a specific record.", searches);
        }
    }
}
