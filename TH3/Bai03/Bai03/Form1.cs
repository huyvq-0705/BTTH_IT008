using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(
                rnd.Next(256),
                rnd.Next(256),
                rnd.Next(256)
            );
        }
    }
}
