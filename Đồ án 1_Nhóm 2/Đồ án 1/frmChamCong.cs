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
    public partial class frmChamCong : Form
    {
        SqlConnection connect;
        SqlCommand cmd;
        public frmChamCong()
        {
            InitializeComponent();
            connect = new SqlConnection(@"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
        }
        private void load_data()
        {
            SqlCommand cmd = new SqlCommand("SELECT b.MaPhieuCC as[Mã phiếu chấm công], a.MaNV as[Mã nhân viên], b.NgayChamCong as [Ngày chấm công], a.TenNV as [Tên nhân viên], a.TinhTrang as [Tình trạng]" +
                "from DONGPHIEUCC a, PHIEUCHAMCONG b WHERE a.MaNV = b.MaNV", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void load_column()
        {
            SqlCommand cmd = new SqlCommand("select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='DONGPHIEUCC'", connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu select được vào database dt
            cbotimkiem.DataSource = dt;
            cbotimkiem.DisplayMember = "column_name";
        }
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            load_column();
            load_data();
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
                DataGridView_colorText();
                DataGridView_CentreHeaders();
                DataGridView_AutoSize();
            }
        }

        private void txtcapnhat_Click(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            load_data();
        }

        private void dtpngaycc_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbotimkiem.Text == "MaNV")
            {
                cmd = new SqlCommand("SELECT b.MaPhieuCC as[Mã phiếu chấm công], a.MaNV as[Mã nhân viên], b.NgayChamCong as [Ngày chấm công], a.TenNV as [Tên nhân viên], a.TinhTrang as [Tình trạng]" +
                "from DONGPHIEUCC a, PHIEUCHAMCONG b WHERE a.MaNV = b.MaNV AND a.MaNV LIKE  N'%" + txttimkiem.Text + "%' ", connect);
            }
            else if (cbotimkiem.Text == "TinhTrang")
            {
                bool tinhtrang = false;
                if (txttimkiem.Text == "đi làm" || txttimkiem.Text == "Đi làm" || txttimkiem.Text == "1")
                {
                    tinhtrang = true;
                }
                cmd = new SqlCommand("SELECT b.MaPhieuCC as[Mã phiếu chấm công], a.MaNV as[Mã nhân viên], b.NgayChamCong as [Ngày chấm công], a.TenNV as [Tên nhân viên], a.TinhTrang as [Tình trạng]" +
                "from DONGPHIEUCC a, PHIEUCHAMCONG b WHERE a.MaNV = b.MaNV AND a.TinhTrang LIKE  N'%" + txttimkiem.Text + "%' ", connect);
                cmd.Parameters.AddWithValue("@TinhTrang", tinhtrang);
            }
            else
            {
                cmd = new SqlCommand("SELECT b.MaPhieuCC as[Mã phiếu chấm công], a.MaNV as[Mã nhân viên], b.NgayChamCong as [Ngày chấm công], a.TenNV as [Tên nhân viên], a.TinhTrang as [Tình trạng]" +
                "from DONGPHIEUCC a, PHIEUCHAMCONG b WHERE a.MaNV = b.MaNV AND a.TenNV LIKE  N'%" + txttimkiem.Text + "%' ", connect);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtxoacc_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ret == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frmChamCong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }
        }
    }
}
