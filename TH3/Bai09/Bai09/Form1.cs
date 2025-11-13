using System;
using System.Linq;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.AllowUserToAddRows = false;

            cbMajor.Items.AddRange(new object[] {
                "Hệ Thống Thông Tin",
                "Khoa Học Máy Tính",
                "Mạng Máy Tính",
                "Kỹ Thuật Phần Mềm",
                "Trí Tuệ Nhân Tạo",
                "An Toàn Thông Tin",
                "Công Nghệ Thông Tin",
                "Công Nghệ Thông Tin Việt Nhật",
                "Khoa Học Dữ Liệu",
                "Kỹ Thuật Máy Tính",
                "Thương Mại Điện Tử",
            });
            cbMajor.SelectedIndex = 0;

            lbAvailable.Items.AddRange(new object[] {
                "Cơ Sở Dữ Liệu",
                "Hệ Điều Hành",
                "Mạng Máy Tính",
                "Lập Trình Web",
                "Lập Trình Java",
                "Lập Trình Python",
                "Kho dữ liệu Olap",
            });

            dgvStudents.Columns.Add("MSSV", "MSSV");
            dgvStudents.Columns.Add("HoTen", "Họ Tên");
            dgvStudents.Columns.Add("ChuyenNganh", "Chuyên Ngành");
            dgvStudents.Columns.Add("GioiTinh", "Giới Tính");
            dgvStudents.Columns.Add("SoMon", "Số Môn");

            chkNam.CheckedChanged += (s, e) => { if (chkNam.Checked) chkNu.Checked = false; };
            chkNu.CheckedChanged += (s, e) => { if (chkNu.Checked) chkNam.Checked = false; };
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            var items = lbAvailable.SelectedItems.Cast<object>().ToArray();
            foreach (var it in items)
            {
                if (!lbSelected.Items.Contains(it))
                    lbSelected.Items.Add(it);
            }
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            var items = lbSelected.SelectedItems.Cast<object>().ToArray();
            foreach (var it in items)
                lbSelected.Items.Remove(it);
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            lbSelected.Items.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string chuyenN = cbMajor.Text;
            string gioiTinh = chkNam.Checked ? "Nam" : chkNu.Checked ? "Nữ" : "";

            if (string.IsNullOrEmpty(mssv) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(chuyenN))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soMon = lbSelected.Items.Count;

            var existing = dgvStudents.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["MSSV"].Value != null && r.Cells["MSSV"].Value.ToString() == mssv);

            if (existing == null)
            {
                dgvStudents.Rows.Add(mssv, hoTen, chuyenN, string.IsNullOrEmpty(gioiTinh) ? "-" : gioiTinh, soMon.ToString());
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            else
            {
                existing.Cells["HoTen"].Value = hoTen;
                existing.Cells["ChuyenNganh"].Value = chuyenN;
                existing.Cells["GioiTinh"].Value = string.IsNullOrEmpty(gioiTinh) ? "-" : gioiTinh;
                existing.Cells["SoMon"].Value = soMon.ToString();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0) return;
            var r = dgvStudents.SelectedRows[0];
            txtMSSV.Text = r.Cells["MSSV"].Value?.ToString();
            txtHoTen.Text = r.Cells["HoTen"].Value?.ToString();
            cbMajor.Text = r.Cells["ChuyenNganh"].Value?.ToString();
            var gt = r.Cells["GioiTinh"].Value?.ToString();
            if (gt == "Nam") { chkNam.Checked = true; chkNu.Checked = false; }
            else if (gt == "Nữ") { chkNu.Checked = true; chkNam.Checked = false; }
            else { chkNam.Checked = chkNu.Checked = false; }

            lbSelected.Items.Clear();
            if (int.TryParse(r.Cells["SoMon"].Value?.ToString(), out int nm) && nm > 0)
            {
                // cannot restore exact course names from grid; leave selected list empty
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            if (string.IsNullOrEmpty(mssv))
            {
                MessageBox.Show("Vui lòng nhập MSSV cần xóa hoặc chọn dòng trong bảng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existing = dgvStudents.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["MSSV"].Value != null && r.Cells["MSSV"].Value.ToString() == mssv);

            if (existing == null)
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dr = MessageBox.Show($"Bạn có chắc muốn xóa học sinh {mssv}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                dgvStudents.Rows.Remove(existing);
                MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            cbMajor.SelectedIndex = 0;
            chkNam.Checked = chkNu.Checked = false;
            lbSelected.Items.Clear();
            txtMSSV.Focus();
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkNam_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
