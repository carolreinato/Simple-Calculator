using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double var1, var2, result;
        string operation;

        private void Clean()
        {
            var1 = 0.0;
            var2 = 0.0;
            operation = String.Empty;
        }

        private void AddNumericCharacter(String character)
        {
            txtDisplay.Text = txtDisplay.Text + character;
        }

        private void AddOperationCharacter(String operatorCharacter)
        {
            if (!txtDisplay.Text.Equals(String.Empty))
            {
                var1 = Convert.ToDouble(txtDisplay.Text);
                operation = operatorCharacter;
                txtDisplay.Clear();
            }
            else
            {
                MessageBox.Show("You must inform a number!");
                return;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Equals(String.Empty))
            {
                var2 = Convert.ToDouble(txtDisplay.Text);
            }
            else
            {
                MessageBox.Show("You must inform a number!");
                return;
            }
            Calculate();
        }

        private void Calculate()
        {
            switch (operation)
            {
                case "/":
                    if (var2 == 0)
                    {
                        MessageBox.Show("Can't divide by zero!");
                        break;
                    }
                    result = var1 / var2;
                    break;
                case "*":
                    result = var1 * var2;
                    break;
                case "+":
                    result = var1 + var2;
                    break;
                case "-":
                    result = var1 - var2;
                    break;
            }
            txtDisplay.Text = result.ToString("F2");
            Clean();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddNumericCharacter("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddNumericCharacter("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddNumericCharacter("9");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddNumericCharacter("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddNumericCharacter("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddNumericCharacter("6");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddNumericCharacter("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddNumericCharacter("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddNumericCharacter("3");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AddNumericCharacter("0");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            AddOperationCharacter("/");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            AddOperationCharacter("*");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            AddOperationCharacter("-");
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            AddOperationCharacter("+");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            Clean();
        }

        private void btnVir_Click(object sender, EventArgs e)
        {
            AddNumericCharacter(",");
        }
    }
}
