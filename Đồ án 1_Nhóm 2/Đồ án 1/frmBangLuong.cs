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
    public partial class frmBangLuong : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public frmBangLuong()
        {
            InitializeComponent();
            con=new SqlConnection(@"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
        }
        private void load_data()
        {
            SqlCommand cmd = new SqlCommand("SELECT b.MaPhieuLuong as [Mã phiếu lương], b.MaNV as [Mã NV], " +
                "a.TenBP as [Tên Bộ Phận], a.TenNV as [Tên Nhân Viên], a.NgayCong as [Ngày Công], " +
                "a.TenChucVu as [Tên Chức Vụ], a.TienThuong as [Tiền Thưởng], a.HeSoLuong as [Hệ Số Lương], " +
                "a.LuongCB as [Lương Cơ Bản], a.PhuCap as [Phụ Cấp], a.ThanhTien as [Thành tiền] from DONGPHIEULUONG a, PHIEULUONG b WHERE a.MaNV=b.MaNV", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //hien thi du lieu len datagridview
        }
        private void load_column()
        {
            SqlCommand cmd = new SqlCommand("select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='DONGPHIEULUONG' and column_name != 'NgayCong' and column_name != 'HeSoLuong' and column_name != 'LuongCB' and column_name !='TienThuong' and column_name != 'PhuCap' and column_name != 'ThanhTien'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu select được vào database dt
            cbotimkem.DataSource = dt;
            cbotimkem.DisplayMember = "column_name";
        }
        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            load_column();
            load_data();
        }

        private void txttukhoa_TextChanged(object sender, EventArgs e)
        {
            if (cbotimkem.Text == "MaNV")
            {
                cmd = new SqlCommand("SELECT b.MaPhieuLuong as [Mã phiếu lương], b.MaNV as [Mã NV], " +
                "a.TenBP as [Tên Bộ Phận], a.TenNV as [Tên Nhân Viên], a.NgayCong as [Ngày Công], " +
                "a.TenChucVu as [Tên Chức Vụ], a.TienThuong as [Tiền Thưởng], a.HeSoLuong as [Hệ Số Lương], " +
                "a.LuongCB as [Lương Cơ Bản], a.PhuCap as [Phụ Cấp], a.ThanhTien as [Thành tiền] from DONGPHIEULUONG a, PHIEULUONG b " +
                "WHERE a.MaNV=b.MaNV AND a.MaNV LIKE  N'%" + txttukhoa.Text + "%' ", con);
            }
            else if (cbotimkem.Text == "TenNV")
            {
                cmd = new SqlCommand("SELECT b.MaPhieuLuong as [Mã phiếu lương], b.MaNV as [Mã NV], " +
                "a.TenBP as [Tên Bộ Phận], a.TenNV as [Tên Nhân Viên], a.NgayCong as [Ngày Công], " +
                "a.TenChucVu as [Tên Chức Vụ], a.TienThuong as [Tiền Thưởng], a.HeSoLuong as [Hệ Số Lương], " +
                "a.LuongCB as [Lương Cơ Bản], a.PhuCap as [Phụ Cấp], a.ThanhTien as [Thành tiền] from DONGPHIEULUONG a, PHIEULUONG b " +
                "WHERE a.MaNV=b.MaNV AND a.TenNV LIKE  N'%" + txttukhoa.Text + "%' ", con);
            }
            else if (cbotimkem.Text == "TenBP")
            {
                cmd = new SqlCommand("SELECT b.MaPhieuLuong as [Mã phiếu lương], b.MaNV as [Mã NV], " +
                "a.TenBP as [Tên Bộ Phận], a.TenNV as [Tên Nhân Viên], a.NgayCong as [Ngày Công], " +
                "a.TenChucVu as [Tên Chức Vụ], a.TienThuong as [Tiền Thưởng], a.HeSoLuong as [Hệ Số Lương], " +
                "a.LuongCB as [Lương Cơ Bản], a.PhuCap as [Phụ Cấp], a.ThanhTien as [Thành tiền] from DONGPHIEULUONG a, PHIEULUONG b " +
                "WHERE a.MaNV=b.MaNV AND a.TenBP LIKE N'%" + txttukhoa.Text + "%' ", con);

            }
            else
            {
                cmd = new SqlCommand("SELECT b.MaPhieuLuong as [Mã phiếu lương], b.MaNV as [Mã NV], " +
                "a.TenBP as [Tên Bộ Phận], a.TenNV as [Tên Nhân Viên], a.NgayCong as [Ngày Công], " +
                "a.TenChucVu as [Tên Chức Vụ], a.TienThuong as [Tiền Thưởng], a.HeSoLuong as [Hệ Số Lương], " +
                "a.LuongCB as [Lương Cơ Bản], a.PhuCap as [Phụ Cấp], a.ThanhTien as [Thành tiền] from DONGPHIEULUONG a, PHIEULUONG b " +
                "WHERE a.MaNV=b.MaNV AND a.TenChucVu LIKE  N'%" + txttukhoa.Text + "%' ", con);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void DataGridView_colorText()
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
        }
        private void DataGridView_CentreHeaders()
        {
            // Centre Column Cells Content
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Centre (Column and Row) Headers    
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set Font Segoe UI, 14pt, style=Bold
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                DataGridView_colorText();
                DataGridView_CentreHeaders();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            txttukhoa.Clear();
            load_data();
        }

        private void frmBangLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát chương trình này??", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
