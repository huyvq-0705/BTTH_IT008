using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        const int Rows = 3;
        const int Cols = 5;
        Button[] seatButtons = new Button[Rows * Cols];
        Color AvailableColor = Color.White;
        Color SoldColor = Color.Yellow;
        Color SelectedColor = Color.DodgerBlue;

        public Form1()
        {
            InitializeComponent();
            InitSeats();
        }

        void InitSeats()
        {
            for (int i = 0; i < Rows * Cols; i++)
            {
                var btn = new Button();
                btn.Size = new Size(50, 40);
                btn.Tag = i + 1;
                btn.Text = (i + 1).ToString();
                btn.BackColor = AvailableColor;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.Click += Seat_Click;
                seatButtons[i] = btn;
                panelSeats.Controls.Add(btn);
            }

            int[] soldIndices = new int[] { 2, 7, 9, 11, 12, 13, 14 };
            foreach (int s in soldIndices)
            {
                if (s >= 1 && s <= seatButtons.Length)
                {
                    seatButtons[s - 1].BackColor = SoldColor;
                }
            }

            LayoutSeats();
            UpdateTotalLabel(0);
        }

        void LayoutSeats()
        {
            panelSeats.Controls.Clear();
            panelSeats.SuspendLayout();
            int padding = 6;
            int startX = 10;
            int startY = 10;
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    int idx = r * Cols + c;
                    var btn = seatButtons[idx];
                    btn.Location = new Point(startX + c * (btn.Width + padding), startY + r * (btn.Height + padding));
                    panelSeats.Controls.Add(btn);
                }
            }
            panelSeats.ResumeLayout();
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;
            if (btn.BackColor == SoldColor)
            {
                MessageBox.Show($"Ghế {btn.Text} đã được bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (btn.BackColor == SelectedColor)
            {
                btn.BackColor = AvailableColor;
            }
            else if (btn.BackColor == AvailableColor)
            {
                btn.BackColor = SelectedColor;
            }
            UpdateSelectedTotalPreview();
        }

        int PriceForSeatIndex(int seatIndex)
        {
            int row = (seatIndex - 1) / Cols;
            if (row == 0) return 8000;
            if (row == 1) return 6500;
            return 5000;
        }

        void UpdateSelectedTotalPreview()
        {
            var selected = seatButtons.Where(b => b.BackColor == SelectedColor).ToArray();
            int total = selected.Sum(b => PriceForSeatIndex((int)b.Tag));
            UpdateTotalLabel(total);
        }

        void UpdateTotalLabel(int total)
        {
            txtThanhTien.Text = total.ToString();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            var selected = seatButtons.Where(b => b.BackColor == SelectedColor).ToArray();
            foreach (var b in selected)
            {
                b.BackColor = SoldColor;
            }
            UpdateSelectedTotalPreview();
            MessageBox.Show($"Đã đặt {selected.Length} vé. Tổng: {txtThanhTien.Text}", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            var selected = seatButtons.Where(b => b.BackColor == SelectedColor).ToArray();
            foreach (var b in selected)
            {
                b.BackColor = AvailableColor;
            }
            UpdateTotalLabel(0);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
