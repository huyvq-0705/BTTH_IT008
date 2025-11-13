using System.Drawing;
using System.Windows.Forms;

namespace Bai07
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelSeats;
        private Label lblTitle;
        private Label lblThanhTien;
        private TextBox txtThanhTien;
        private Button btnChon;
        private Button btnHuyBo;
        private Button btnKetThuc;

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
            this.panelSeats = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // panelSeats
            this.panelSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSeats.Location = new System.Drawing.Point(20, 60);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(340, 170);
            this.panelSeats.TabIndex = 0;
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 32);
            this.lblTitle.Text = "MÀN ẢNH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblThanhTien
            this.lblThanhTien.Location = new System.Drawing.Point(20, 245);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(100, 23);
            this.lblThanhTien.Text = "Thành Tiền:";
            // txtThanhTien
            this.txtThanhTien.Location = new System.Drawing.Point(120, 245);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(120, 23);
            this.txtThanhTien.Text = "0";
            // btnChon
            this.btnChon.Location = new System.Drawing.Point(20, 285);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(80, 30);
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // btnHuyBo
            this.btnHuyBo.Location = new System.Drawing.Point(115, 285);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(80, 30);
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // btnKetThuc
            this.btnKetThuc.Location = new System.Drawing.Point(210, 285);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(80, 30);
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // Form1
            this.ClientSize = new System.Drawing.Size(380, 330);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnKetThuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BÁN VÉ RẠP CHIẾU BÓNG";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
