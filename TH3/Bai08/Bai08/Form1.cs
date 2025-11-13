using System;
using System.Linq;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTongTien.ReadOnly = true;
            lvAccounts.FullRowSelect = true;
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            string soTK = txtSoTaiKhoan.Text.Trim();
            string ten = txtTenKH.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string soTienText = txtSoTien.Text.Trim();

            if (string.IsNullOrEmpty(soTK) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soTienText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(soTienText, out long soTien) || soTien < 0)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existing = lvAccounts.Items.Cast<ListViewItem>().FirstOrDefault(it => it.SubItems[1].Text == soTK);
            if (existing == null)
            {
                int stt = lvAccounts.Items.Count + 1;
                var itm = new ListViewItem(stt.ToString());
                itm.SubItems.Add(soTK);
                itm.SubItems.Add(ten);
                itm.SubItems.Add(diaChi);
                itm.SubItems.Add(soTien.ToString());
                lvAccounts.Items.Add(itm);
                RecalculateTotal();
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            else
            {
                existing.SubItems[2].Text = ten;
                existing.SubItems[3].Text = diaChi;
                existing.SubItems[4].Text = soTien.ToString();
                ReindexStt();
                RecalculateTotal();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string soTK = txtSoTaiKhoan.Text.Trim();
            if (string.IsNullOrEmpty(soTK))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existing = lvAccounts.Items.Cast<ListViewItem>().FirstOrDefault(it => it.SubItems[1].Text == soTK);
            if (existing == null)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dr = MessageBox.Show($"Bạn có chắc muốn xóa tài khoản {soTK}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                lvAccounts.Items.Remove(existing);
                ReindexStt();
                RecalculateTotal();
                MessageBox.Show("Xóa tài khoản thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private void lvAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAccounts.SelectedItems.Count == 0) return;
            var it = lvAccounts.SelectedItems[0];
            txtSoTaiKhoan.Text = it.SubItems[1].Text;
            txtTenKH.Text = it.SubItems[2].Text;
            txtDiaChi.Text = it.SubItems[3].Text;
            txtSoTien.Text = it.SubItems[4].Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RecalculateTotal()
        {
            long total = 0;
            foreach (ListViewItem it in lvAccounts.Items)
            {
                if (long.TryParse(it.SubItems[4].Text, out long v))
                    total += v;
            }
            txtTongTien.Text = total.ToString();
        }

        private void ReindexStt()
        {
            for (int i = 0; i < lvAccounts.Items.Count; i++)
            {
                lvAccounts.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void ClearInputs()
        {
            txtSoTaiKhoan.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();
            txtSoTaiKhoan.Focus();
        }
    }
}
