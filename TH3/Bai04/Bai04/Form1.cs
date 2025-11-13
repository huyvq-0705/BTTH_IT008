using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        ColorDialog dlg = new ColorDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void menuColor_Click(object sender, EventArgs e)
        {
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dlg.Color;
            }
        }
    }
}
