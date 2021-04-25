using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_calc_Click(object sender, EventArgs e)
        {
            double Uq = Convert.ToDouble(txt_source.Text);
            double Ul = Convert.ToDouble(txt_currentPart.Text);
            double Pl = Convert.ToDouble(txt_power.Text);
            double Ur = Uq - Ul;

            double I = Pl / Ul;

            double Rv = Ur / I;

            MessageBox.Show("Result:\n\nThe resistor has to have at least" + Rv.ToString() + " Ohm!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_currentPart.Text = "0";
            txt_power.Text = "0";
            txt_source.Text = "0";
        }
    }
}
