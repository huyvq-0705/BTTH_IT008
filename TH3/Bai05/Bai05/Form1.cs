using System;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool TryGetInputs(out double a, out double b)
        {
            a = 0;
            b = 0;
            if (!double.TryParse(txtNumber1.Text.Trim(), out a)) return false;
            if (!double.TryParse(txtNumber2.Text.Trim(), out b)) return false;
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b))
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtAnswer.Text = (a + b).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b))
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtAnswer.Text = (a - b).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b))
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtAnswer.Text = (a * b).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b))
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Math.Abs(b) < double.Epsilon)
            {
                MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtAnswer.Text = (a / b).ToString();
        }
    }
}