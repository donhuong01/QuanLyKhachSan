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
    public partial class frmThongTinNV : Form
    {
        SqlConnection connect;
        SqlDataAdapter adapter;
        DataTable table;
        public frmThongTinNV()
        {
            InitializeComponent();
            connect = new SqlConnection(@"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            adapter = new SqlDataAdapter("select * from NHANVIEN", connect);
            table = new DataTable();
        }
        private void load_data()
        {
            SqlCommand cmd = new SqlCommand("select MaNV as [Mã nhân viên], UserName, " +
                "TenNV as [Tên nhân viên], TenBP as [Tên bộ phận], NgaySinh as [Ngày sinh], " +
                "case GioiTinh When 1 then 'Nam' else N'Nữ' end as [Giới Tính], DiaChi as [Địa chỉ], " +
                "Email, SoDT as [Số điện thoại], ChucVu as [Chức vụ], ViTriLamViec as [Vị trí làm việc] from NHANVIEN", connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //hien thi du lieu len datagridview
        }
        private void resetvalue()
        {
            txthoten.Clear();
            txtemail.Clear();
            rbtnnam.Checked = default;
            txtdiachi.Clear();
            txtsodt.Clear();
            txttimkiem.Clear();
            txthoten.Focus();
        }
        public void load_Column()
        {
            SqlCommand cmd = new SqlCommand("select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='NHANVIEN' and column_name != 'NgaySinh' and column_name != 'UserName' and column_name != 'Email' and column_name != 'SoDT' and column_name != 'DiaChi'", connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu select được vào database dt
            cbotimkiem.DataSource = dt;
            cbotimkiem.DisplayMember = "column_name";
        }
        private void frmThongTinNV_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            table.Clear();
            adapter.Fill(table);
            cbotimkiem.DataSource = table;
            cbotimkiem.DisplayMember = "MaNV";
            dataGridView1.DataSource = table;
            load_data();
            load_Column();
            txthoten.Text = "";
            txtemail.Text = "";
            txtdiachi.Text = "";
            txtsodt.Text = "";
            rbtnnam.Checked = true;
            txthoten.Focus();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                this.txthoten.Text = dataGridView1.Rows[dongchon].Cells[2].Value.ToString();
                this.dtpngaysinh.Value = Convert.ToDateTime(dataGridView1.Rows[dongchon].Cells[4].Value);
                if (dataGridView1.Rows[dongchon].Cells[5].Value.ToString() == "Nam") rbtnnam.Checked = true;
                else rbtnnu.Checked = true;
                this.txtdiachi.Text = dataGridView1.Rows[dongchon].Cells[6].Value.ToString();
                this.txtemail.Text = dataGridView1.Rows[dongchon].Cells[7].Value.ToString();
                this.txtsodt.Text = dataGridView1.Rows[dongchon].Cells[8].Value.ToString();
            }
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                DataGridView_colorText();
                DataGridView_CentreHeaders();
            }
        }

        private void btnrefesh_Click(object sender, EventArgs e)
        {
            resetvalue();
            load_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            if (cbotimkiem.Text == "GioiTinh")
            {
                bool gioiTinh = false;
                if (txttimkiem.Text == "Nam" || txttimkiem.Text == "nam" || txttimkiem.Text == "1")
                {
                    gioiTinh = true;
                }
                cmd = new SqlCommand("SELECT MaNV as [Mã nhân viên], UserName, " +
                "TenNV as [Tên nhân viên], TenBP as [Tên bộ phận], NgaySinh as [Ngày sinh], " +
                "case GioiTinh When 1 then 'Nam' else N'Nữ' end as [Giới Tính], DiaChi as [Địa chỉ], " +
                "Email, SoDT as [Số điện thoại], ChucVu as [Chức vụ], ViTriLamViec as [Vị trí làm việc] " +
                "from NHANVIEN WHERE GioiTinh = @GioiTinh ", connect);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            }
            else
            {
                cmd = new SqlCommand("SELECT MaNV as [Mã nhân viên], UserName, " +
                "TenNV as [Tên nhân viên], TenBP as [Tên bộ phận], NgaySinh as [Ngày sinh], " +
                "case GioiTinh When 1 then 'Nam' else N'Nữ' end as [Giới Tính], DiaChi as [Địa chỉ], " +
                "Email, SoDT as [Số điện thoại], ChucVu as [Chức vụ], ViTriLamViec as [Vị trí làm việc] " +
                "from NHANVIEN WHERE " + cbotimkiem.Text + " Like N'%" + txttimkiem.Text + "%' ", connect);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int dongchon = this.dataGridView1.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand("Update NHANVIEN set TenNV=@TenNV,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,DiaChi=@DiaChi,Email=@Email,SoDT=@SoDT where MaNV=@MaNV", connect);
            cmd.Parameters.AddWithValue("@MaNV", dataGridView1.Rows[dongchon].Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@TenNV", txthoten.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", this.dtpngaysinh.Value);
            if (rbtnnam.Checked) cmd.Parameters.AddWithValue("@GioiTinh", true);
            else cmd.Parameters.AddWithValue("@GioiTinh", false);
            cmd.Parameters.AddWithValue("@DiaChi", this.txtdiachi.Text);
            cmd.Parameters.AddWithValue("@Email", this.txtemail.Text);
            cmd.Parameters.AddWithValue("@SoDT", this.txtsodt.Text);
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
            load_data();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmThongTinNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }
        }
    }
}
