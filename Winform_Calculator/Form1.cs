using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool isOperationPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (txtbResult.Text == "0" || isOperationPressed)
            {
                txtbResult.Clear();
            }
            isOperationPressed = false;
            Button btnClick = (Button)sender;
            txtbResult.Text = txtbResult.Text + btnClick.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            operation = btnOperator.Text;
            value = double.Parse(txtbResult.Text);
            isOperationPressed = true;
            lbTemp.Text = value + " " + operation;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtbResult.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lbTemp.Text = "";
            switch (operation)
            {
                case "+":
                    txtbResult.Text = (value + double.Parse(txtbResult.Text)).ToString();
                    break;
                case "-":
                    txtbResult.Text = (value - double.Parse(txtbResult.Text)).ToString();
                    break;
                case "*":
                    txtbResult.Text = (value * double.Parse(txtbResult.Text)).ToString();
                    break;
                case "/":
                    txtbResult.Text = (value / double.Parse(txtbResult.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtbResult.Clear();
            value = 0;
        }
    }
}
