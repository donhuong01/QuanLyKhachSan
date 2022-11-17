using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Đồ_án_1
{
    public partial class frmlichlamviec : Form
    {
        SqlConnection connect;
        SqlCommand cmd;

        public frmlichlamviec()
        {
            InitializeComponent();
            connect = new SqlConnection(@"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
        }
        private void load_data()
        {
            SqlCommand cmd = new SqlCommand("SELECT b.SoLichLV as[Số lịch làm việc], b.MaNV as [Mã nhân viên], a.TenNV as [Tên nhân viên], a.TenBP as [Tên bộ phận], " +
                "b.CaLam as [Ca làm], b.GioVaoLam as [Giờ vào làm], b.GioTanLam as [Giờ tan làm]," +
                "b.ViTriLamViec as [Vị trí làm việc], b.NhiemVu as [Nhiệm vụ] from DONGLICHLV a, LICHLAMVIEC b WHERE a.MaNV = b.MaNV", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void load_column()
        {
            SqlCommand cmd = new SqlCommand("select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='LICHLAMVIEC' and column_name != 'SoLichLV' and column_name != 'GioVaoLam' and column_name != 'GioTanLam' and column_name != 'NhiemVu'", connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu select được vào database dt
            cbotimkiem.DataSource = dt;
            cbotimkiem.DisplayMember = "column_name";
        }
        private void frmlichlamviec_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            load_data();
            load_column();
        }
        private void DataGridView_colorText()
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
        }
        private void DataGridView_CentreHeaders()
        {
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        private void DataGridView_AutoSize()
        {
            var col = dataGridView1.Columns;

            for (int i = 0; i < col.Count; i++)
            {
                if (i == 0) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 1) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 2) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 3) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 4) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 5) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 6) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 7) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 8) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 9) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 10) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                // Etc...
            }
        }
        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                DataGridView_AutoSize();
                DataGridView_colorText();
                DataGridView_CentreHeaders();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbotimkiem.Text == "MaNV")
            {
                string strTimKiem = "select b.SoLichLV as[Số lịch làm việc], b.MaNV as [Mã nhân viên], a.TenNV as [Tên nhân viên], a.TenBP as [Tên bộ phận]," +
                "b.CaLam as [Ca làm], b.GioVaoLam as [Giờ vào làm], b.GioTanLam as [Giờ tan làm]," +
                "b.ViTriLamViec as [Vị trí làm việc], b.NhiemVu as [Nhiệm vụ] from DONGLICHLV as a, LICHLAMVIEC as b WHERE a.MaNV = b.MaNV AND b.MaNV like  N'%" + txttimkiem.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connect);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr);
                dataGridView1.DataSource = dt1;
            }
            else if (cbotimkiem.Text == "CaLam")
            {
                string strTimKiem = "select b.SoLichLV as[Số lịch làm việc], b.MaNV as [Mã nhân viên], a.TenNV as [Tên nhân viên], a.TenBP as [Tên bộ phận]," +
                "b.CaLam as [Ca làm], b.GioVaoLam as [Giờ vào làm], b.GioTanLam as [Giờ tan làm]," +
                "b.ViTriLamViec as [Vị trí làm việc], b.NhiemVu as [Nhiệm vụ] from DONGLICHLV as a, LICHLAMVIEC as b WHERE a.MaNV = b.MaNV AND b.CaLam LIKE  N'%" + txttimkiem.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connect);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr);
                dataGridView1.DataSource = dt1;
            }
            else if (cbotimkiem.Text == "ViTriLamViec")
            {
                string strTimKiem = "select b.SoLichLV as[Số lịch làm việc], b.MaNV as [Mã nhân viên], a.TenNV as [Tên nhân viên], a.TenBP as [Tên bộ phận], " +
                "b.CaLam as [Ca làm], b.GioVaoLam as [Giờ vào làm], b.GioTanLam as [Giờ tan làm]," +
                "b.ViTriLamViec as [Vị trí làm việc], b.NhiemVu as [Nhiệm vụ] from DONGLICHLV as a, LICHLAMVIEC as b WHERE a.MaNV = b.MaNV AND b.ViTriLamViec LIKE  N'%" + txttimkiem.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connect);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("Không tìm thấy bản ghi nào thỏa mãn điều kiện tìm kiếm!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            load_data();
        }

        private void frmlichlamviec_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ret == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
