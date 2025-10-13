namespace Nguyenthibachvien_1150080122_lab5
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.labelChonLop = new System.Windows.Forms.Label();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.lsvSinhVien = new System.Windows.Forms.ListView();
            this.colMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQueQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            this.groupBoxThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(400, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(380, 25);
            this.labelTitle.Text = "Sửa dữ liệu không dùng Parameter";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.cbMaLop);
            this.groupBoxFilter.Controls.Add(this.labelChonLop);
            this.groupBoxFilter.Location = new System.Drawing.Point(20, 50);
            this.groupBoxFilter.Size = new System.Drawing.Size(1140, 60);
            this.groupBoxFilter.Text = "";
            // 
            // labelChonLop
            // 
            this.labelChonLop.AutoSize = true;
            this.labelChonLop.Location = new System.Drawing.Point(15, 25);
            this.labelChonLop.Text = "Chọn mã lớp:";
            // 
            // cbMaLop
            // 
            this.cbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLop.Location = new System.Drawing.Point(100, 20);
            this.cbMaLop.Size = new System.Drawing.Size(180, 24);
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.lsvSinhVien);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(20, 120);
            this.groupBoxDanhSach.Size = new System.Drawing.Size(750, 400);
            this.groupBoxDanhSach.Text = "Danh sách sinh viên:";
            // 
            // lsvSinhVien
            // 
            this.lsvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMaSV, this.colTenSV, this.colGioiTinh,
                this.colNgaySinh, this.colQueQuan, this.colMaLop});
            this.lsvSinhVien.FullRowSelect = true;
            this.lsvSinhVien.GridLines = true;
            this.lsvSinhVien.HideSelection = false;
            this.lsvSinhVien.Location = new System.Drawing.Point(10, 25);
            this.lsvSinhVien.Size = new System.Drawing.Size(730, 360);
            this.lsvSinhVien.View = System.Windows.Forms.View.Details;
            this.colMaSV.Text = "Mã SV"; this.colMaSV.Width = 90;
            this.colTenSV.Text = "Tên SV"; this.colTenSV.Width = 150;
            this.colGioiTinh.Text = "Giới tính"; this.colGioiTinh.Width = 80;
            this.colNgaySinh.Text = "Ngày sinh"; this.colNgaySinh.Width = 120;
            this.colQueQuan.Text = "Quê quán"; this.colQueQuan.Width = 160;
            this.colMaLop.Text = "Mã lớp"; this.colMaLop.Width = 100;
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.txtMaSV);
            this.groupBoxThongTin.Controls.Add(this.txtTenSV);
            this.groupBoxThongTin.Controls.Add(this.cbGioiTinh);
            this.groupBoxThongTin.Controls.Add(this.dtpNgaySinh);
            this.groupBoxThongTin.Controls.Add(this.txtQueQuan);
            this.groupBoxThongTin.Controls.Add(this.txtMaLop);
            this.groupBoxThongTin.Controls.Add(this.btnSua);
            this.groupBoxThongTin.Controls.Add(this.label1);
            this.groupBoxThongTin.Controls.Add(this.label2);
            this.groupBoxThongTin.Controls.Add(this.label3);
            this.groupBoxThongTin.Controls.Add(this.label4);
            this.groupBoxThongTin.Controls.Add(this.label5);
            this.groupBoxThongTin.Controls.Add(this.label6);
            this.groupBoxThongTin.Location = new System.Drawing.Point(790, 120);
            this.groupBoxThongTin.Size = new System.Drawing.Size(370, 400);
            this.groupBoxThongTin.Text = "Thông tin sinh viên:";
            // 
            // txtMaSV - txtMaLop
            // 
            this.txtMaSV.Location = new System.Drawing.Point(120, 40);
            this.txtTenSV.Location = new System.Drawing.Point(120, 75);
            this.cbGioiTinh.Location = new System.Drawing.Point(120, 110);
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dtpNgaySinh.Location = new System.Drawing.Point(120, 145);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtQueQuan.Location = new System.Drawing.Point(120, 180);
            this.txtMaLop.Location = new System.Drawing.Point(120, 215);
            this.txtMaSV.Size = this.txtTenSV.Size = this.txtQueQuan.Size =
                this.txtMaLop.Size = new System.Drawing.Size(200, 22);
            this.cbGioiTinh.Size = new System.Drawing.Size(200, 24);
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(100, 270);
            this.btnSua.Size = new System.Drawing.Size(180, 40);
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // labels trong groupBoxThongTin
            // 
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Text = "Mã SV:";
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Text = "Tên SV:";
            this.label3.Location = new System.Drawing.Point(20, 115);
            this.label3.Text = "Giới tính:";
            this.label4.Location = new System.Drawing.Point(20, 150);
            this.label4.Text = "Ngày sinh:";
            this.label5.Location = new System.Drawing.Point(20, 185);
            this.label5.Text = "Quê quán:";
            this.label6.Location = new System.Drawing.Point(20, 220);
            this.label6.Text = "Mã lớp:";
            // 
            // FormSuaSinhVien
            // 
            this.ClientSize = new System.Drawing.Size(1180, 550);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.groupBoxThongTin);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa dữ liệu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBoxDanhSach.ResumeLayout(false);
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.Label labelChonLop;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.ListView lsvSinhVien;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
        private System.Windows.Forms.ColumnHeader colMaLop;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
