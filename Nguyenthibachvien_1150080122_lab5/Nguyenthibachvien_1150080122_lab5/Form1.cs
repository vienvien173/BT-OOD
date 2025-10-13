using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nguyenthibachvien_1150080122_lab5
{
    public partial class Form1 : Form
    {
        // 1) Chuỗi kết nối LocalDB (dùng |DataDirectory| cho .mdf trong project)
        private readonly string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Năm 4\BTood\Nguyenthibachvien_1150080122_lab5\Nguyenthibachvien_1150080122_lab5\Database1.mdf"";Integrated Security=True";

        // 2) Đối tượng kết nối dùng chung
        private SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        // 3) Mở kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        // 4) Đóng kết nối
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        // 5) Hiển thị danh sách sinh viên lên ListView
        private void HienThiDanhSach()
        {
            try
            {
                MoKetNoi();

                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop FROM SinhVien";
                    sqlCmd.Connection = sqlCon;

                    lsvDanhSachSV.Items.Clear();

                    using (SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maSv = reader.GetString(0);
                            string tenSV = reader.GetString(1);
                            string gioiTinh = reader.GetString(2);
                            string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                            string queQuan = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            string maLop = reader.GetString(5);

                            ListViewItem lvi = new ListViewItem(maSv);
                            lvi.SubItems.Add(tenSV);
                            lvi.SubItems.Add(gioiTinh);
                            lvi.SubItems.Add(ngaySinh);
                            lvi.SubItems.Add(queQuan);
                            lvi.SubItems.Add(maLop);
                            lsvDanhSachSV.Items.Add(lvi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        // 6) Xử lý nút Thêm (KHÔNG dùng parameter theo yêu cầu bài)
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ UI
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtTenSV.Text.Trim();
            // Tránh dùng SelectedText (thường rỗng). Dùng Text hoặc SelectedItem
            string gioiTinh = string.IsNullOrWhiteSpace(cbGioiTinh.Text) ? "" : cbGioiTinh.Text.Trim();

            // Vì KHÔNG dùng parameter, ta định dạng ngày nhất quán yyyy-MM-dd để SQL hiểu đúng
            string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");

            string queQuan = txtQueQuan.Text.Trim();
            string maLop = txtMaLop.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(tenSV) ||
                string.IsNullOrEmpty(gioiTinh) || string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng nhập đủ Mã SV, Tên SV, Giới tính, Mã lớp.");
                return;
            }

            try
            {
                MoKetNoi();

                // CẢNH BÁO: đoạn này ghép chuỗi trực tiếp theo đúng bài thực hành 2 (dễ bị SQL Injection).
                string sqlInsert =
                    "INSERT INTO SinhVien(MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop) " +
                    "VALUES ('" + maSV + "', N'" + tenSV.Replace("'", "''") + "', N'" + gioiTinh.Replace("'", "''") +
                    "', '" + ngaySinh + "', N'" + queQuan.Replace("'", "''") + "', N'" + maLop.Replace("'", "''") + "')";

                using (SqlCommand cmd = new SqlCommand(sqlInsert, sqlCon))
                {
                    int kq = cmd.ExecuteNonQuery(); // ExecuteNonQuery để INSERT
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm sinh viên thành công!");
                        HienThiDanhSach();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được dữ liệu!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu bị lỗi! " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void ClearInputs()
        {
            txtMaSV.Clear();
            txtTenSV.Clear();
            cbGioiTinh.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Today;
            txtQueQuan.Clear();
            txtMaLop.Clear();
            txtMaSV.Focus();
        }

        // 7) Form Load: nạp ComboBox & danh sách
        private void Form1_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;

            HienThiDanhSach();
        }
    }
}
