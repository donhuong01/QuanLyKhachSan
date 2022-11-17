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
    public partial class frmNhanVien : Form
    {
        SqlConnection connec;
        SqlCommand cmd;
        string str = @"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmNhanVien()
        {
            InitializeComponent();
            connec = new SqlConnection();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            connec = new SqlConnection(str);
            connec.Open();
            rbtnnam.Checked = true;
            load_Colum();
            loaddata();
        }
        public void load_Colum()
        {
            SqlCommand cmd = new SqlCommand("select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='NHANVIEN' and column_name != 'NgaySinh' and column_name != 'GioiTinh' and column_name != 'SoDT' and column_name != 'Email' and column_name != 'DiaChi'", connec);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu select được vào database dt
            cbotimkem.DataSource = dt;
            cbotimkem.DisplayMember = "column_name";
        }
        void loaddata()
        {
            cmd = connec.CreateCommand();
            cmd.CommandText = "Select * from NHANVIEN";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            //cbotimkem.DataSource = table;
            //cbotimkem.DisplayMember = "MaNV";
            dataGridView1.DataSource = table;
        }
        private void frmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connec.State != ConnectionState.Closed)
            {
                connec.Close();
            }
        }
        public bool kiemtra()
        {
            if (string.IsNullOrWhiteSpace(txtmaNV.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập mã nhân viên của nhân viên");
                txtmaNV.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txthoten.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập tên nhân viên của nhân viên");
                txthoten.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txttenbp.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập tên bộ phận của nhân viên");
                txttenbp.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtdiachi.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập địa chỉ của nhân viên");
                txtdiachi.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtemail.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập email của nhân viên");
                txtemail.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtsodt.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập số điện thoại của nhân viên");
                txtsodt.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtchucvu.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập chức vụ của nhân viên");
                txtchucvu.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtvitri.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập vị trí của nhân viên");
                txtvitri.Focus();
                return false;
            }
            return true;
        }
        void resetvalue()
        {
            txtmaNV.Clear();
            txthoten.Clear();
            txtuser.Clear();
            txttenbp.Clear();
            txtvitri.Clear();
            txtemail.Clear();
            txtdiachi.Clear();
            rbtnnam.Checked = true;
            txtchucvu.Clear();
            txtsodt.Clear();
            txtmaNV.Focus();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string sqlCHECK = "Select count(*) MaNV from NHANVIEN where MaNV=@MaNV";
            SqlCommand cmdl = new SqlCommand(sqlCHECK, connec);
            if (kiemtra())
            {
                try
                {
                    cmdl.Parameters.AddWithValue("@MaNV", txtmaNV.Text);

                    int val = (int)cmdl.ExecuteScalar();
                    if (val > 0)
                    {
                        MessageBox.Show("Mã nhân viên này đã tồn tại!");
                    }
                    else
                    {
                        string sqlINSERT = "INSERT INTO NHANVIEN(MaNV,UserName,TenNV,TenBP,NgaySinh,GioiTinh,DiaChi,Email,SoDT,ChucVu,ViTriLamViec) values (@MaNV,@UserName,@TenNV,@TenBP,@NgaySinh,@GioiTinh,@DiaChi,@Email,@SoDT,@ChucVu,@ViTriLamViec)";
                        SqlCommand cmd = new SqlCommand(sqlINSERT, connec);
                        cmd.Parameters.AddWithValue("@MaNV", this.txtmaNV.Text);
                        cmd.Parameters.AddWithValue("@UserName", this.txtuser.Text);
                        cmd.Parameters.AddWithValue("@TenNV", this.txthoten.Text);
                        cmd.Parameters.AddWithValue("@TenBP", this.txttenbp.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", this.dtpngaysinh.Value);
                        if (rbtnnam.Checked)
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", true);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", false);
                        }
                        cmd.Parameters.AddWithValue("@DiaChi", this.txtdiachi.Text);
                        cmd.Parameters.AddWithValue("@Email", this.txtemail.Text);
                        cmd.Parameters.AddWithValue("@SoDT", this.txtsodt.Text);
                        cmd.Parameters.AddWithValue("@ChucVu", this.txtchucvu.Text);
                        cmd.Parameters.AddWithValue("@ViTriLamViec", this.txtvitri.Text);

                        if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Thêm thành công");
                        else MessageBox.Show("Thêm thất bại");
                        resetvalue();
                        loaddata();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int dongchon = this.dataGridView1.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand("Update NHANVIEN set MaNV=@MaNV,TenNV=@TenNV,TenBP=@TenBP,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,DiaChi=@DiaChi,Email=@Email,SoDT=@SoDT,ChucVu=@ChucVu,ViTriLamViec=@ViTriLamViec where MaNV=@MaNV", connec);
            cmd.Parameters.AddWithValue("@MaNV", this.txtmaNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", this.txthoten.Text);
            cmd.Parameters.AddWithValue("@TenBP", this.txttenbp.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", this.dtpngaysinh.Value);
            if (rbtnnam.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", true);
            }
            else
            {
                cmd.Parameters.AddWithValue("@GioiTinh", false);
            }
            cmd.Parameters.AddWithValue("@DiaChi", this.txtdiachi.Text);
            cmd.Parameters.AddWithValue("@Email", this.txtemail.Text);
            cmd.Parameters.AddWithValue("@SoDT", this.txtsodt.Text);
            cmd.Parameters.AddWithValue("@ChucVu", this.txtchucvu.Text);
            cmd.Parameters.AddWithValue("@ViTrilamViec", this.txtvitri.Text);
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Sửa thành công :)");
            else MessageBox.Show("Sửa thất bại :(");
            loaddata();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttukhoa.Text.Trim()))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbotimkem.Text == "MaNV")
            {
                string strTimKiem = "SELECT * FROM NHANVIEN WHERE " + cbotimkem.Text + " like '%" + txttukhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connec);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else if (cbotimkem.Text == "UserName")
            {
                string strTimKiem = "SELECT * FROM NHANVIEN WHERE " + cbotimkem.Text + " like N'%" + txttukhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connec);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else if (cbotimkem.Text == "TenNV")
            {
                string strTimKiem = "SELECT * FROM NHANVIEN WHERE " + cbotimkem.Text + " like N'%" + txttukhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connec);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else if (cbotimkem.Text == "TenBP")
            {
                string strTimKiem = "SELECT * FROM NHANVIEN WHERE " + cbotimkem.Text + " like N'%" + txttukhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connec);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else if(cbotimkem.Text== "ChucVu")
            {
                string strTimKiem = "SELECT * FROM NHANVIEN WHERE " + cbotimkem.Text + " like N'%" + txttukhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connec);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else if (cbotimkem.Text == "ViTriLamViec")
            {
                string strTimKiem = "SELECT * FROM NHANVIEN WHERE " + cbotimkem.Text + " like N'%" + txttukhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connec);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu thỏa mãn điều kiện");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa???", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM NHANVIEN WHERE MaNV = @MaNV", connec);
                    cmd.Parameters.AddWithValue("@MaNV", this.txtmaNV.Text);
                    cmd.Parameters.AddWithValue("@TenNV", this.txthoten.Text);
                    cmd.Parameters.AddWithValue("@TenBP", this.txttenbp.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", this.dtpngaysinh.Value);
                    if (rbtnnam.Checked)
                    {
                        cmd.Parameters.AddWithValue("@GioiTinh", true);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@GioiTinh", false);
                    }
                    cmd.Parameters.AddWithValue("@DiaChi", this.txtdiachi.Text);
                    cmd.Parameters.AddWithValue("@Email", this.txtemail.Text);
                    cmd.Parameters.AddWithValue("@SoDT", this.txtsodt.Text);
                    cmd.Parameters.AddWithValue("@ChucVu", this.txtchucvu.Text);
                    cmd.Parameters.AddWithValue("@ViTrilamViec", this.txtvitri.Text);
                    if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Xóa thành công");
                    else MessageBox.Show("Xóa thất bại");
                    resetvalue();
                    loaddata();

                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            int i;
            i = dataGridView1.CurrentRow.Index;
            if (i >= 0)
            {
                this.txtmaNV.Text = dataGridView1.Rows[i].Cells["MaNV"].Value.ToString();
                this.txtuser.Text = dataGridView1.Rows[i].Cells["UserName"].Value.ToString();
                this.txthoten.Text = dataGridView1.Rows[i].Cells["TenNV"].Value.ToString();
                this.txttenbp.Text = dataGridView1.Rows[i].Cells["TenBP"].Value.ToString();
                this.dtpngaysinh.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells["NgaySinh"].Value);
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["GioiTinh"].Value) == true)
                {
                    rbtnnam.Checked = true;
                }
                else
                {
                    rbtnnu.Checked = true;
                }
                this.txtdiachi.Text = dataGridView1.Rows[i].Cells["DiaChi"].Value.ToString();
                this.txtemail.Text = dataGridView1.Rows[i].Cells["Email"].Value.ToString();
                this.txtsodt.Text = dataGridView1.Rows[i].Cells["SoDT"].Value.ToString();
                this.txtchucvu.Text = dataGridView1.Rows[i].Cells["ChucVu"].Value.ToString();
                this.txtvitri.Text = dataGridView1.Rows[i].Cells["ViTriLamViec"].Value.ToString();
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

        private void btnrefesh_Click(object sender, EventArgs e)
        {
            resetvalue();
            loaddata();
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                DataGridView_colorText();
                DataGridView_CentreHeaders();
            }
        }

    }
}
