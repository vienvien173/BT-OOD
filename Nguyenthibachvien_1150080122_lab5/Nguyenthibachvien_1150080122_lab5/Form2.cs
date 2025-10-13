using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nguyenthibachvien_1150080122_lab5
{
    public partial class Form2 : Form
    {
        // Kết nối tới CSDL
        private string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Năm 4\BTood\Nguyenthibachvien_1150080122_lab5\Nguyenthibachvien_1150080122_lab5\Database1.mdf"";Integrated Security=True";
        private SqlConnection sqlCon = null;

        public Form2()
        {
            InitializeComponent();
        }

        // =========================
        // 1️⃣ MỞ KẾT NỐI
        // =========================
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        // =========================
        // 2️⃣ ĐÓNG KẾT NỐI
        // =========================
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        // =========================
        // 3️⃣ LOAD FORM
        // =========================
        private void Form2_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");

            HienThiDanhSach();
            NapDanhSachLop();
        }

        // =========================
        // 4️⃣ HIỂN THỊ DANH SÁCH SV
        // =========================
        private void HienThiDanhSach(string maLop = "")
        {
            try
            {
                MoKetNoi();
                string sql = "SELECT * FROM SinhVien";

                if (!string.IsNullOrEmpty(maLop))
                    sql += " WHERE MaLop = @MaLop";

                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                if (!string.IsNullOrEmpty(maLop))
                    cmd.Parameters.AddWithValue("@MaLop", maLop);

                SqlDataReader reader = cmd.ExecuteReader();

                lsvSinhVien.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader["MaSV"].ToString());
                    lvi.SubItems.Add(reader["TenSV"].ToString());
                    lvi.SubItems.Add(reader["GioiTinh"].ToString());
                    lvi.SubItems.Add(Convert.ToDateTime(reader["NgaySinh"]).ToShortDateString());
                    lvi.SubItems.Add(reader["QueQuan"].ToString());
                    lvi.SubItems.Add(reader["MaLop"].ToString());

                    lsvSinhVien.Items.Add(lvi);
                }

                reader.Close();
                DongKetNoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách: " + ex.Message);
            }
        }

        // =========================
        // 5️⃣ NẠP DANH SÁCH LỚP
        // =========================
        private void NapDanhSachLop()
        {
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT MaLop FROM SinhVien", sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();

                cbMaLop.Items.Clear();
                while (reader.Read())
                {
                    cbMaLop.Items.Add(reader["MaLop"].ToString());
                }
                reader.Close();
                DongKetNoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp lớp: " + ex.Message);
            }
        }

        // =========================
        // 6️⃣ LỌC THEO MÃ LỚP
        // =========================
        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cbMaLop.SelectedItem?.ToString();
            HienThiDanhSach(maLop);
        }

        // =========================
        // 7️⃣ CLICK CHỌN 1 SINH VIÊN
        // =========================
        private void lsvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSinhVien.SelectedItems.Count == 0)
                return;

            ListViewItem item = lsvSinhVien.SelectedItems[0];
            txtMaSV.Text = item.SubItems[0].Text;
            txtTenSV.Text = item.SubItems[1].Text;
            cbGioiTinh.Text = item.SubItems[2].Text;
            dtpNgaySinh.Value = DateTime.Parse(item.SubItems[3].Text);
            txtQueQuan.Text = item.SubItems[4].Text;
            txtMaLop.Text = item.SubItems[5].Text;
        }

        // =========================
        // 8️⃣ NÚT SỬA THÔNG TIN
        // =========================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            try
            {
                MoKetNoi();

                string sql = @"UPDATE SinhVien 
                               SET TenSV = @TenSV, 
                                   GioiTinh = @GioiTinh, 
                                   NgaySinh = @NgaySinh, 
                                   QueQuan = @QueQuan, 
                                   MaLop = @MaLop 
                               WHERE MaSV = @MaSV";

                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text);
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên để cập nhật!");
                }

                DongKetNoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }
    }
}
