using System.Windows.Forms;
using System.Drawing;

namespace Bai08
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblSoTK;
        private Label lblTenKH;
        private Label lblDiaChi;
        private Label lblSoTien;
        private TextBox txtSoTaiKhoan;
        private TextBox txtTenKH;
        private TextBox txtDiaChi;
        private TextBox txtSoTien;
        private Button btnThemCapNhat;
        private Button btnXoa;
        private Button btnThoat;
        private ListView lvAccounts;
        private ColumnHeader chSTT;
        private ColumnHeader chSoTK;
        private ColumnHeader chTen;
        private ColumnHeader chDiaChi;
        private ColumnHeader chSoTien;
        private Label lblTong;
        private TextBox txtTongTien;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new Label();
            this.lblSoTK = new Label();
            this.lblTenKH = new Label();
            this.lblDiaChi = new Label();
            this.lblSoTien = new Label();
            this.txtSoTaiKhoan = new TextBox();
            this.txtTenKH = new TextBox();
            this.txtDiaChi = new TextBox();
            this.txtSoTien = new TextBox();
            this.btnThemCapNhat = new Button();
            this.btnXoa = new Button();
            this.btnThoat = new Button();
            this.lvAccounts = new ListView();
            this.chSTT = new ColumnHeader();
            this.chSoTK = new ColumnHeader();
            this.chTen = new ColumnHeader();
            this.chDiaChi = new ColumnHeader();
            this.chSoTien = new ColumnHeader();
            this.lblTong = new Label();
            this.txtTongTien = new TextBox();

            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(820, 520);

            this.lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.Blue;
            this.lblTitle.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Size = new System.Drawing.Size(800, 50);

            int left = 30;
            int top = 80;
            int labelW = 140;
            int tbW = 540;
            int gapY = 36;

            this.lblSoTK.Location = new System.Drawing.Point(left, top);
            this.lblSoTK.Size = new System.Drawing.Size(labelW, 23);
            this.lblSoTK.Text = "Số tài khoản";

            this.txtSoTaiKhoan.Location = new System.Drawing.Point(left + labelW, top);
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(tbW, 23);

            this.lblTenKH.Location = new System.Drawing.Point(left, top + gapY);
            this.lblTenKH.Size = new System.Drawing.Size(labelW, 23);
            this.lblTenKH.Text = "Tên khách hàng";

            this.txtTenKH.Location = new System.Drawing.Point(left + labelW, top + gapY);
            this.txtTenKH.Size = new System.Drawing.Size(tbW, 23);

            this.lblDiaChi.Location = new System.Drawing.Point(left, top + gapY * 2);
            this.lblDiaChi.Size = new System.Drawing.Size(labelW, 23);
            this.lblDiaChi.Text = "Địa chỉ khách hàng";

            this.txtDiaChi.Location = new System.Drawing.Point(left + labelW, top + gapY * 2);
            this.txtDiaChi.Size = new System.Drawing.Size(tbW, 23);

            this.lblSoTien.Location = new System.Drawing.Point(left, top + gapY * 3);
            this.lblSoTien.Size = new System.Drawing.Size(labelW, 23);
            this.lblSoTien.Text = "Số tiền trong tài khoản";

            this.txtSoTien.Location = new System.Drawing.Point(left + labelW, top + gapY * 3);
            this.txtSoTien.Size = new System.Drawing.Size(tbW, 23);

            this.btnThemCapNhat.Location = new System.Drawing.Point(left + labelW, top + gapY * 4 + 4);
            this.btnThemCapNhat.Size = new System.Drawing.Size(120, 30);
            this.btnThemCapNhat.Text = "Thêm / Cập Nhật";
            this.btnThemCapNhat.Click += new System.EventHandler(this.btnThemCapNhat_Click);

            this.btnXoa.Location = new System.Drawing.Point(left + labelW + 130, top + gapY * 4 + 4);
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnThoat.Location = new System.Drawing.Point(left + labelW + 220, top + gapY * 4 + 4);
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.lvAccounts.Location = new System.Drawing.Point(20, top + gapY * 5 + 8);
            this.lvAccounts.Size = new System.Drawing.Size(780, 300);
            this.lvAccounts.View = View.Details;
            this.lvAccounts.FullRowSelect = true;
            this.lvAccounts.GridLines = true;
            this.lvAccounts.Columns.AddRange(new ColumnHeader[] { this.chSTT, this.chSoTK, this.chTen, this.chDiaChi, this.chSoTien });
            this.lvAccounts.SelectedIndexChanged += new System.EventHandler(this.lvAccounts_SelectedIndexChanged);

            this.chSTT.Text = "STT";
            this.chSTT.Width = 50;
            this.chSoTK.Text = "Mã tài khoản";
            this.chSoTK.Width = 150;
            this.chTen.Text = "Tên khách hàng";
            this.chTen.Width = 220;
            this.chDiaChi.Text = "Địa chỉ";
            this.chDiaChi.Width = 220;
            this.chSoTien.Text = "Số tiền";
            this.chSoTien.Width = 120;
            this.chSoTien.TextAlign = HorizontalAlignment.Right;

            this.lblTong.Location = new System.Drawing.Point(20, top + gapY * 5 + 320);
            this.lblTong.Size = new System.Drawing.Size(80, 23);
            this.lblTong.Text = "Tổng tiền:";

            this.txtTongTien.Location = new System.Drawing.Point(110, top + gapY * 5 + 320);
            this.txtTongTien.Size = new System.Drawing.Size(200, 23);
            this.txtTongTien.ReadOnly = true;

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSoTK);
            this.Controls.Add(this.txtSoTaiKhoan);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.btnThemCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lvAccounts);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.txtTongTien);

            this.Text = "Quản Lý Tài Khoản";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
