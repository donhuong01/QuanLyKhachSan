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
    public partial class frmPhong : Form
    {
        SqlConnection connect;//biến thành viên
        SqlCommand cmd;
        SqlCommandBuilder builder;
        string str = @"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmPhong()
        {
            InitializeComponent();
            cmd = new SqlCommand();
            builder = new SqlCommandBuilder(adapter);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void load_Colum()
        {
            SqlCommand cmd = new SqlCommand("select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='PHONG' and column_name !='MoTaPhong'", connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu select được vào database dt
            cbotimkiem.DataSource = dt;
            cbotimkiem.DisplayMember = "column_name";
        }
        public void load_data()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from PHONG";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            cboloaiphong.DataSource = table;
            cboloaiphong.DisplayMember = "LoaiPhong";
            dataGridView1.DataSource = table;
        }
        private void resetValue()
        {
            txtmaphong.Clear();
            txttenphong.Clear();
            txtvitri.Clear();
            txtsoluong.Clear();
            txtmota.Clear();
            rbtnthue.Checked = true;
            txtdongia.Clear();
            txtmaphong.Focus();
        }
        public bool kiemtra()
        {
            if(string.IsNullOrWhiteSpace(txtmaphong.Text.Trim())|| string.IsNullOrWhiteSpace(txttenphong.Text.Trim())|| string.IsNullOrWhiteSpace(txtsoluong.Text.Trim())
                || string.IsNullOrWhiteSpace(txtmota.Text.Trim())|| string.IsNullOrWhiteSpace(txtvitri.Text.Trim())
                || string.IsNullOrWhiteSpace(txtdongia.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtmaphong.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtmaphong.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập mã phòng thêm", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtmaphong.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txttenphong.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập tên phòng thêm", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txttenphong.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtvitri.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập vị trí phòng thêm", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtvitri.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtsoluong.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập số lượng phòng thêm", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtsoluong.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtmota.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập mô tả phòng thêm", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtmota.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtdongia.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập đơn giá phòng thêm", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtdongia.Focus();
                return false;
            }
            return true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string sqlCHECK = "Select count(*) MaPhong from PHONG where MaPhong = @MaPhong";
            SqlCommand cmdl = new SqlCommand(sqlCHECK, connect);
            if (kiemtra())
            {
                try
                {
                    cmdl.Parameters.AddWithValue(@"MaPhong", txtmaphong.Text);

                    int val = (int)cmdl.ExecuteScalar();
                    if (val > 0)
                    {
                        MessageBox.Show("Mã phòng này đã tồn tại!");
                    }
                    else
                    {
                        string sqlINSERT = "INSERT INTO PHONG values (@MaPhong,@TenPhong,@LoaiPhong,@ViTriPhong,@SoLuong,@TinhTrang,@MoTaPhong,@DonGia)";
                        SqlCommand cmd = new SqlCommand(sqlINSERT, connect);
                        cmd.Parameters.AddWithValue("@MaPhong", this.txtmaphong.Text);
                        cmd.Parameters.AddWithValue("@TenPhong", this.txttenphong.Text);
                        cmd.Parameters.AddWithValue("@LoaiPhong", this.cboloaiphong.Text);
                        cmd.Parameters.AddWithValue("@ViTriPhong", this.txtvitri.Text);
                        cmd.Parameters.AddWithValue("@SoLuong", this.txtsoluong.Text);
                        if (rbtnthue.Checked)
                        {
                            cmd.Parameters.AddWithValue("@TinhTrang", true);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@TinhTrang", false);
                        }
                        cmd.Parameters.AddWithValue("@MoTaPhong", this.txtmota.Text);
                        cmd.Parameters.AddWithValue("@DonGia", this.txtdongia.Text);
                        if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Thêm thành công :)");
                        else MessageBox.Show("Thêm dữ liệu thất bại :(");
                        resetValue();
                        load_data();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(str);
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            load_data();
            load_Colum();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = this.dataGridView1.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand("Update PHONG set MaPhong=@MaPhong,TenPhong=@TenPhong,LoaiPhong=@LoaiPhong,ViTriPhong=@ViTriPhong,SoLuong=@SoLuong,TinhTrang=@TinhTrang,MoTaPhong=@MoTaPhong,DonGia=@DonGia where MaPhong=@MaPhong", connect);
            cmd.Parameters.AddWithValue("@MaPhong", this.txtmaphong.Text);
            cmd.Parameters.AddWithValue("@TenPhong", this.txttenphong.Text);
            cmd.Parameters.AddWithValue("@LoaiPhong", this.cboloaiphong.Text);
            cmd.Parameters.AddWithValue("@ViTriPhong", this.txtvitri.Text);
            cmd.Parameters.AddWithValue("@SoLuong", this.txtsoluong.Text);
            if (rbtnthue.Checked)
            {
                cmd.Parameters.AddWithValue("@TinhTrang", true);
            }
            else
            {
                cmd.Parameters.AddWithValue("@TinhTrang", false);
            }
            cmd.Parameters.AddWithValue("@MoTaPhong", this.txtmota.Text);
            cmd.Parameters.AddWithValue("@DonGia", this.txtdongia.Text);
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
            load_data();
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
        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM PHONG WHERE MaPhong = @MaPhong", connect);
                    cmd.Parameters.AddWithValue("@MaPhong", this.txtmaphong.Text);
                    cmd.Parameters.AddWithValue("@TenPhong", this.txttenphong.Text);
                    cmd.Parameters.AddWithValue("@LoaiPhong", this.cboloaiphong.Text);
                    cmd.Parameters.AddWithValue("@ViTriPhong", this.txtvitri.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", this.txtsoluong.Text);
                    if (rbtnthue.Checked)
                    {
                        cmd.Parameters.AddWithValue("@TinhTrang", true);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@TinhTrang", false);
                    }
                    cmd.Parameters.AddWithValue("@MoTaPhong", this.txtmota.Text);
                    cmd.Parameters.AddWithValue("@DonGia", this.txtdongia.Text);
                    cmd.ExecuteNonQuery();
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                    frmPhong_Load(sender, e);
                    resetValue();
                    load_data();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn thoát không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (f == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnrefesh_Click(object sender, EventArgs e)
        {
            resetValue();
            load_data();
        }

        private void frmPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttukhoa.Text.Trim()))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbotimkiem.Text == "TrangThai")
            {
                bool trangthai = false;
                if (txttukhoa.Text == "Còn trống" || txttukhoa.Text == "còn trống" || txttukhoa.Text == "1")
                {
                    trangthai = true;
                }
                cmd = new SqlCommand("SELECT * FROM PHONG WHERE TrangThai = @TrangThai", connect);
                cmd.Parameters.AddWithValue("@TrangThai", trangthai);
            }
            else if (cbotimkiem.Text == "SoLuong")
            {
                string strTimKiem = "SELECT * FROM PHONG WHERE " + cbotimkiem.Text + " like '%" + Convert.ToInt32(txttukhoa.Text) + "%'";
                cmd = new SqlCommand(strTimKiem, connect);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else if (cbotimkiem.Text == "DonGia")
            {
                string strTimKiem = "SELECT * FROM PHONG WHERE " + cbotimkiem.Text + " like '%" + Convert.ToDecimal(txttukhoa.Text) + "%'";
                cmd = new SqlCommand(strTimKiem, connect);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else
            {
                string strTimKiem = "SELECT * FROM PHONG WHERE " + cbotimkiem.Text + " like N'%" + txttukhoa.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connect);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                this.txtmaphong.Text = dataGridView1.Rows[dongchon].Cells["MaPhong"].Value.ToString();
                this.txttenphong.Text = dataGridView1.Rows[dongchon].Cells["TenPhong"].Value.ToString();
                cboloaiphong.Text = dataGridView1.Rows[dongchon].Cells["LoaiPhong"].Value.ToString();
                this.txtvitri.Text = dataGridView1.Rows[dongchon].Cells["ViTriPhong"].Value.ToString();
                this.txtsoluong.Text = dataGridView1.Rows[dongchon].Cells["SoLuong"].Value.ToString();
                if (Convert.ToBoolean(dataGridView1.Rows[dongchon].Cells["TinhTrang"].Value) == true)
                {
                    rbtnthue.Checked = true;
                }
                else
                {
                    rbtntrong.Checked = true;
                }
                this.txtmota.Text = dataGridView1.Rows[dongchon].Cells["MoTaPhong"].Value.ToString();
                this.txtdongia.Text = dataGridView1.Rows[dongchon].Cells["DonGia"].Value.ToString();
            }
        }
    }
}
