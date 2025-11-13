using System;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Constructor: Form đang được khởi tạo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load: Form vừa tải xong (chưa hiển thị)");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Shown: Form đã hiển thị lần đầu");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lblStatus.Text = "Form Activated";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            lblStatus.Text = "Form Paint (vẽ lại Form)";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            lblStatus.Text = "Form Resize";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("FormClosing: Form chuẩn bị đóng");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("FormClosed: Form đã đóng xong");
        }
    }
}
