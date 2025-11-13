using System;
using System.Globalization;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        double memory = 0;
        double current = 0;
        double lastOperand = 0;
        string lastOperator = "";
        bool enteringNumber = false;
        bool justCalculated = false;

        public Form1()
        {
            InitializeComponent();
            txtDisplay.Text = "0";
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            if (justCalculated)
            {
                txtDisplay.Text = "0";
                justCalculated = false;
            }
            if (!enteringNumber || txtDisplay.Text == "0")
            {
                txtDisplay.Text = b.Text;
                enteringNumber = true;
            }
            else
            {
                txtDisplay.Text += b.Text;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (justCalculated)
            {
                txtDisplay.Text = "0";
                justCalculated = false;
                enteringNumber = true;
            }
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
                enteringNumber = true;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            if (enteringNumber)
            {
                if (!string.IsNullOrEmpty(lastOperator))
                {
                    Calculate();
                }
                else
                {
                    current = ParseDisplay();
                }
                enteringNumber = false;
            }
            lastOperator = b.Tag.ToString();
            justCalculated = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (enteringNumber)
            {
                lastOperand = ParseDisplay();
            }
            else
            {
                lastOperand = lastOperand;
            }
            Calculate();
            lastOperator = "";
            justCalculated = true;
            enteringNumber = false;
        }

        private void Calculate()
        {
            double x = current;
            double y = lastOperand;
            if (!enteringNumber && !justCalculated)
            {
                y = lastOperand;
            }
            else
            {
                y = ParseDisplay();
                lastOperand = y;
            }

            switch (lastOperator)
            {
                case "+":
                    current = x + y;
                    break;
                case "-":
                    current = x - y;
                    break;
                case "*":
                    current = x * y;
                    break;
                case "/":
                    if (Math.Abs(y) < double.Epsilon)
                    {
                        txtDisplay.Text = "Cannot divide by zero";
                        enteringNumber = false;
                        return;
                    }
                    current = x / y;
                    break;
                default:
                    current = y;
                    break;
            }
            txtDisplay.Text = FormatNumber(current);
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            enteringNumber = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            current = 0;
            lastOperand = 0;
            lastOperator = "";
            enteringNumber = false;
            memory = 0;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (justCalculated) return;
            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
                enteringNumber = false;
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.StartsWith("-"))
                txtDisplay.Text = txtDisplay.Text.Substring(1);
            else if (txtDisplay.Text != "0")
                txtDisplay.Text = "-" + txtDisplay.Text;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double v = ParseDisplay();
            if (v < 0)
            {
                txtDisplay.Text = "Invalid input";
                enteringNumber = false;
                return;
            }
            txtDisplay.Text = FormatNumber(Math.Sqrt(v));
            enteringNumber = false;
            justCalculated = true;
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            double v = ParseDisplay();
            if (Math.Abs(v) < double.Epsilon)
            {
                txtDisplay.Text = "Cannot divide by zero";
                enteringNumber = false;
                return;
            }
            txtDisplay.Text = FormatNumber(1.0 / v);
            enteringNumber = false;
            justCalculated = true;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double v = ParseDisplay();
            txtDisplay.Text = FormatNumber(v / 100.0);
            enteringNumber = false;
            justCalculated = true;
        }

        private void Memory_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            switch (b.Tag.ToString())
            {
                case "MC":
                    memory = 0;
                    break;
                case "MR":
                    txtDisplay.Text = FormatNumber(memory);
                    enteringNumber = false;
                    break;
                case "MS":
                    memory = ParseDisplay();
                    enteringNumber = false;
                    break;
                case "M+":
                    memory += ParseDisplay();
                    enteringNumber = false;
                    break;
            }
        }

        private double ParseDisplay()
        {
            if (double.TryParse(txtDisplay.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double v))
                return v;
            if (double.TryParse(txtDisplay.Text, out v))
                return v;
            return 0;
        }

        private string FormatNumber(double v)
        {
            return v.ToString("G15", CultureInfo.InvariantCulture).TrimEnd('0').TrimEnd('.');
        }
    }
}
