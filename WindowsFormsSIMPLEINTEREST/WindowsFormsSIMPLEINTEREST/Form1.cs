using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSIMPLEINTEREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textPrincipal.Text, out double principal) &&
                double.TryParse(textRate.Text, out double rate) &&
                double.TryParse(textTime.Text, out double time))
            {
                double si = (principal * rate * time) / 100;
                textResult.Text = $" Simple Interest = {si}";
            }
            else
            {
                MessageBox.Show(" PLEASE ENTER VALID NUMERIC VALUES ");
            }
        }
    }
}
