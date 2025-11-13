using System.Drawing;
using System.Windows.Forms;

namespace Bai09
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupInfo;
        private Label lblMSSV;
        private Label lblHoTen;
        private Label lblMajor;
        private Label lblGioiTinh;
        private Label lblCourses;
        private TextBox txtMSSV;
        private TextBox txtHoTen;
        private ComboBox cbMajor;
        private CheckBox chkNam;
        private CheckBox chkNu;
        private ListBox lbAvailable;
        private ListBox lbSelected;
        private Button btnAddCourse;
        private Button btnRemoveCourse;
        private Button btnClearSelected;
        private Button btnSave;
        private Button btnDelete;
        private DataGridView dgvStudents;
        private Label lblSelectedCount;

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
            groupInfo = new GroupBox();
            lblMSSV = new Label();
            txtMSSV = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblMajor = new Label();
            cbMajor = new ComboBox();
            lblGioiTinh = new Label();
            chkNam = new CheckBox();
            chkNu = new CheckBox();
            lblCourses = new Label();
            lbAvailable = new ListBox();
            btnAddCourse = new Button();
            btnRemoveCourse = new Button();
            btnClearSelected = new Button();
            lbSelected = new ListBox();
            lblSelectedCount = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            dgvStudents = new DataGridView();
            groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // groupInfo
            // 
            groupInfo.Controls.Add(lblMSSV);
            groupInfo.Controls.Add(txtMSSV);
            groupInfo.Controls.Add(lblHoTen);
            groupInfo.Controls.Add(txtHoTen);
            groupInfo.Controls.Add(lblMajor);
            groupInfo.Controls.Add(cbMajor);
            groupInfo.Controls.Add(lblGioiTinh);
            groupInfo.Controls.Add(chkNam);
            groupInfo.Controls.Add(chkNu);
            groupInfo.Controls.Add(lblCourses);
            groupInfo.Controls.Add(lbAvailable);
            groupInfo.Controls.Add(btnAddCourse);
            groupInfo.Controls.Add(btnRemoveCourse);
            groupInfo.Controls.Add(btnClearSelected);
            groupInfo.Controls.Add(lbSelected);
            groupInfo.Controls.Add(lblSelectedCount);
            groupInfo.Location = new Point(12, 12);
            groupInfo.Name = "groupInfo";
            groupInfo.Size = new Size(876, 320);
            groupInfo.TabIndex = 0;
            groupInfo.TabStop = false;
            groupInfo.Text = "Thông Tin Sinh Viên";
            // 
            // lblMSSV
            // 
            lblMSSV.Location = new Point(20, 30);
            lblMSSV.Name = "lblMSSV";
            lblMSSV.Size = new Size(120, 22);
            lblMSSV.TabIndex = 0;
            lblMSSV.Text = "Mã Sinh Viên";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(160, 28);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(220, 27);
            txtMSSV.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(20, 70);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(120, 22);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(160, 68);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(520, 27);
            txtHoTen.TabIndex = 3;
            // 
            // lblMajor
            // 
            lblMajor.Location = new Point(20, 110);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(120, 22);
            lblMajor.TabIndex = 4;
            lblMajor.Text = "Chuyên Ngành";
            // 
            // cbMajor
            // 
            cbMajor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMajor.Location = new Point(160, 108);
            cbMajor.Name = "cbMajor";
            cbMajor.Size = new Size(320, 28);
            cbMajor.TabIndex = 5;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(20, 150);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(120, 22);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // chkNam
            // 
            chkNam.Location = new Point(160, 148);
            chkNam.Name = "chkNam";
            chkNam.Size = new Size(71, 22);
            chkNam.TabIndex = 7;
            chkNam.Text = "Nam";
            chkNam.CheckedChanged += chkNam_CheckedChanged_1;
            // 
            // chkNu
            // 
            chkNu.Location = new Point(246, 148);
            chkNu.Name = "chkNu";
            chkNu.Size = new Size(60, 22);
            chkNu.TabIndex = 8;
            chkNu.Text = "Nữ";
            chkNu.CheckedChanged += chkNu_CheckedChanged;
            // 
            // lblCourses
            // 
            lblCourses.Location = new Point(20, 190);
            lblCourses.Name = "lblCourses";
            lblCourses.Size = new Size(200, 22);
            lblCourses.TabIndex = 9;
            lblCourses.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // lbAvailable
            // 
            lbAvailable.Location = new Point(20, 220);
            lbAvailable.Name = "lbAvailable";
            lbAvailable.SelectionMode = SelectionMode.MultiExtended;
            lbAvailable.Size = new Size(300, 104);
            lbAvailable.TabIndex = 10;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(340, 240);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(40, 28);
            btnAddCourse.TabIndex = 11;
            btnAddCourse.Text = ">";
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnRemoveCourse
            // 
            btnRemoveCourse.Location = new Point(340, 280);
            btnRemoveCourse.Name = "btnRemoveCourse";
            btnRemoveCourse.Size = new Size(40, 28);
            btnRemoveCourse.TabIndex = 12;
            btnRemoveCourse.Text = "<";
            btnRemoveCourse.Click += btnRemoveCourse_Click;
            // 
            // btnClearSelected
            // 
            btnClearSelected.Location = new Point(340, 320);
            btnClearSelected.Name = "btnClearSelected";
            btnClearSelected.Size = new Size(40, 28);
            btnClearSelected.TabIndex = 13;
            btnClearSelected.Text = "Xóa";
            btnClearSelected.Click += btnClearSelected_Click;
            // 
            // lbSelected
            // 
            lbSelected.Location = new Point(400, 220);
            lbSelected.Name = "lbSelected";
            lbSelected.Size = new Size(300, 104);
            lbSelected.TabIndex = 14;
            // 
            // lblSelectedCount
            // 
            lblSelectedCount.Location = new Point(400, 360);
            lblSelectedCount.Name = "lblSelectedCount";
            lblSelectedCount.Size = new Size(200, 22);
            lblSelectedCount.TabIndex = 15;
            lblSelectedCount.Text = "Số môn đã chọn: 0";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(212, 338);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 30);
            btnSave.TabIndex = 16;
            btnSave.Text = "Lưu Thông Tin";
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(412, 339);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 30);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa Học Sinh";
            btnDelete.Click += btnDeleteStudent_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudents.ColumnHeadersHeight = 29;
            dgvStudents.Location = new Point(12, 397);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(876, 303);
            dgvStudents.TabIndex = 1;
            // 
            // Form1
            // 
            ClientSize = new Size(900, 720);
            Controls.Add(groupInfo);
            Controls.Add(dgvStudents);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Name = "Form1";
            Text = "Nhập Liệu Sinh Viên";
            groupInfo.ResumeLayout(false);
            groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }
    }
}
