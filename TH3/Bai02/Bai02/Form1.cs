using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        Random _rnd = new Random();
        List<Point> _positions = new List<Point>();
        Font _font = new Font("Segoe UI", 12, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string text = "Paint Event";
            SizeF textSize = e.Graphics.MeasureString(text, _font);
            int maxX = Math.Max(1, ClientSize.Width - (int)Math.Ceiling(textSize.Width));
            int maxY = Math.Max(1, ClientSize.Height - (int)Math.Ceiling(textSize.Height));
            int x = _rnd.Next(0, maxX);
            int y = _rnd.Next(0, maxY);
            _positions.Add(new Point(x, y));

            using (Brush b = new SolidBrush(Color.Black))
            {
                foreach (var p in _positions)
                {
                    e.Graphics.DrawString(text, _font, b, p);
                }
            }

            using (Brush b = new SolidBrush(Color.DarkBlue))
            {
                e.Graphics.DrawString($"Paint calls: {_positions.Count}", new Font("Segoe UI", 9), b, 10, ClientSize.Height - 24);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _positions.Clear();
            Invalidate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _font.Dispose();
        }
    }
}
