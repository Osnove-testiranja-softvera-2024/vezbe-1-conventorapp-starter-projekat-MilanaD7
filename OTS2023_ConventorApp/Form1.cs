using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        double a;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbMass_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Pounds";
            label2.Text = "Kg";
            a = 0.45359237;
            
        }

        private void rbLenght_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Feet";
            label2.Text = "Meters";
            a = 0.3048;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            textBox2.Text= (Convert.ToInt32(textBox1.Text) * a).ToString();
        }
    }
}
