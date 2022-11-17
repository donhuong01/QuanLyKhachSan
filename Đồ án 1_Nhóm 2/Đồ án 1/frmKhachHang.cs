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
    public partial class frmKhachHang : Form
    {
        SqlConnection connec;
        SqlCommand cmd;
        string str = @"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmKhachHang()
        {
            InitializeComponent();
            connec = new SqlConnection();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        public void load_Colum()
        {
            SqlCommand cmd = new SqlCommand("select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='KHACHHANG' and column_name != 'EmailKH' and column_name != 'GioiTinh' and column_name != 'CMND' and column_name != 'SoDT' and column_name != 'DiaChi'", connec);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu select được vào database dt
            cbotimkiem.DataSource = dt;
            cbotimkiem.DisplayMember = "column_name";
        }
        void loaddata()
        {
            cmd = connec.CreateCommand();
            cmd.CommandText = "Select * from KHACHHANG";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            //cbotimkem.DataSource = table;
            //cbotimkem.DisplayMember = "MaNV";
            dataGridView1.DataSource = table;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            connec = new SqlConnection(str);
            connec.Open();
            rbtnnam.Checked = true;
            load_Colum();
            loaddata();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkhoa.Text.Trim()))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbotimkiem.Text == "LichHen")
            {
                string strTimKiem = "SELECT * FROM KHACHHANG WHERE " + cbotimkiem.Text + " like '%" + Convert.ToDateTime(txtkhoa.Text) + "%'";
                cmd = new SqlCommand(strTimKiem, connec);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else
            {
                string strTimKiem = "SELECT * FROM KHACHHANG WHERE " + cbotimkiem.Text + " like N'%" + txtkhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connec);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
        }

        public bool kiemtra()
        {
            if (string.IsNullOrWhiteSpace(txtmaKH.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập mã nhân viên của khách hàng");
                txtmaKH.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txthoten.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập tên của khách hàng");
                txthoten.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtcmnd.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập CMND của khách hàng");
                txtcmnd.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtdiachi.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập địa chỉ của khách hàng");
                txtdiachi.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtemail.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập email của khách hàng");
                txtemail.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtsdt.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập số điện thoại của khách hàng");
                txtsdt.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtquoctich.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập quốc tịch của khách hàng");
                txtquoctich.Focus();
                return false;
            }
            return true;
        }
        void resetvalue()
        {
            txtmaKH.Clear();
            txthoten.Clear();
            txtquoctich.Clear();
            txtcmnd.Clear();
            txtemail.Clear();
            txtdiachi.Clear();
            rbtnnam.Checked = true;
            txtsdt.Clear();
            txtkhoa.Clear();
            txtmaKH.Focus();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string sqlCHECK = "Select count(*) MaKH from KHACHHANG where MaKH=@MaKH";
            SqlCommand cmdl = new SqlCommand(sqlCHECK, connec);
            if (kiemtra())
            {
                try
                {
                    cmdl.Parameters.AddWithValue("@MaKH", txtmaKH.Text);

                    int val = (int)cmdl.ExecuteScalar();
                    if (val > 0)
                    {
                        MessageBox.Show("Mã nhân viên này đã tồn tại!");
                    }
                    else
                    {
                        string sqlINSERT = "INSERT INTO KHACHHANG (MaKH,TenKH,CMND,EmailKH,SoDT,DiaChi,QuocTich,GioiTinh,LichHen) values (@MaKH,@TenKH,@CMND,@EmailKH,@SoDT,@DiaChi,@QuocTich,@GioiTinh,@LichHen)";
                        SqlCommand cmd = new SqlCommand(sqlINSERT, connec);
                        cmd.Parameters.AddWithValue("@MaKH", this.txtmaKH.Text);
                        cmd.Parameters.AddWithValue("@TenKH", this.txthoten.Text);
                        cmd.Parameters.AddWithValue("@CMND", this.txtcmnd.Text);
                        cmd.Parameters.AddWithValue("@EmailKH", this.txtemail.Text);
                        cmd.Parameters.AddWithValue("@SoDT", this.txtsdt.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", this.txtdiachi.Text);
                        cmd.Parameters.AddWithValue("@QuocTich", this.txtquoctich.Text);
                        if (rbtnnam.Checked)
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", true);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@GioiTinh", false);
                        }
                        
                        cmd.Parameters.AddWithValue("@LichHen", this.dtplichhen.Value);

                        if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Thêm thành công");
                        else MessageBox.Show("Thêm thất bại");
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
            SqlCommand cmd = new SqlCommand("Update KHACHHANG set MaKH=@MaKH,TenKH=@TenKH,CMND=@CMND,EmailKH=@EmailKH,SoDT=@SoDT,DiaChi=@DiaChi,QuocTich=@QuocTich,GioiTinh=@GioiTinh,LichHen=@LichHen where MaKH=@MaKH", connec);
            cmd.Parameters.AddWithValue("@MaKH", this.txtmaKH.Text);
            cmd.Parameters.AddWithValue("@TenKH", this.txthoten.Text);
            cmd.Parameters.AddWithValue("@CMND", this.txtcmnd.Text);
            cmd.Parameters.AddWithValue("@EmailKH", this.txtemail.Text);
            cmd.Parameters.AddWithValue("@SoDT", this.txtsdt.Text);
            cmd.Parameters.AddWithValue("@DiaChi", this.txtdiachi.Text);
            cmd.Parameters.AddWithValue("@QuocTich", this.txtquoctich.Text);
            if (rbtnnam.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", true);
            }
            else
            {
                cmd.Parameters.AddWithValue("@GioiTinh", false);
            }

            cmd.Parameters.AddWithValue("@LichHen", this.dtplichhen.Value);
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Sửa thành công :)");
            else MessageBox.Show("Sửa thất bại :(");
            loaddata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa??", "Hỏi xóa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM KHACHHANG WHERE MaKH = @MaKH", connec);
                    cmd.Parameters.AddWithValue("@MaKH", this.txtmaKH.Text);
                    cmd.Parameters.AddWithValue("@TenKH", this.txthoten.Text);
                    cmd.Parameters.AddWithValue("@CMND", this.txtcmnd.Text);
                    cmd.Parameters.AddWithValue("@EmailKH", this.txtemail.Text);
                    cmd.Parameters.AddWithValue("@SoDT", this.txtsdt.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", this.txtdiachi.Text);
                    cmd.Parameters.AddWithValue("@QuocTich", this.txtquoctich.Text);
                    if (rbtnnam.Checked)
                    {
                        cmd.Parameters.AddWithValue("@GioiTinh", true);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@GioiTinh", false);
                    }

                    cmd.Parameters.AddWithValue("@LichHen", this.dtplichhen.Value);
                    if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Xóa thành công!!");
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

        private void btnrefesh_Click(object sender, EventArgs e)
        {
            resetvalue();
            loaddata();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát chương trình này??", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connec.State != ConnectionState.Closed)
            {
                connec.Close();
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

        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkhoa.Text.Trim()))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbotimkiem.Text == "MaKH")
            {
                string strTimKiem = "SELECT * FROM KHACHHANG WHERE " + cbotimkiem.Text + " like '%" + txtkhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connec);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else if (cbotimkiem.Text == "TenKH")
            {
                string strTimKiem = "SELECT * FROM KHACHHANG WHERE " + cbotimkiem.Text + " like N'%" + txtkhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connec);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else if (cbotimkiem.Text == "QuocTich")
            {
                string strTimKiem = "SELECT * FROM KHACHHANG WHERE " + cbotimkiem.Text + " like N'%" + txtkhoa.Text + "%'";
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

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát chương trình này??", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            if (i >= 0)
            {
                this.txtmaKH.Text = dataGridView1.Rows[i].Cells["MaKH"].Value.ToString();
                this.txthoten.Text = dataGridView1.Rows[i].Cells["TenKH"].Value.ToString();
                this.txtcmnd.Text = dataGridView1.Rows[i].Cells["CMND"].Value.ToString();
                this.txtemail.Text = dataGridView1.Rows[i].Cells["EmailKH"].Value.ToString();
                this.txtsdt.Text = dataGridView1.Rows[i].Cells["SoDT"].Value.ToString();
                this.txtdiachi.Text = dataGridView1.Rows[i].Cells["DiaChi"].Value.ToString();
                this.txtquoctich.Text = dataGridView1.Rows[i].Cells["QuocTich"].Value.ToString();
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["GioiTinh"].Value) == true)
                {
                    rbtnnam.Checked = true;
                }
                else
                {
                    rbtnnu.Checked = true;
                }
                this.dtplichhen.Text = dataGridView1.Rows[i].Cells["LichHen"].Value.ToString();
            }
        }
    }
}
