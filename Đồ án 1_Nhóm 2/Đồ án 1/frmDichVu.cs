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
    public partial class frmDichVu : Form
    {
        SqlConnection connect;
        SqlCommand cmd;
        public frmDichVu()
        {
            InitializeComponent();
            connect = new SqlConnection();
        }

        private void btntim_Click(object sender, EventArgs e)
        {

        }
        public void load_Colum()
        {
            SqlCommand cmd = new SqlCommand("select column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='DICHVU' and column_name != 'MoTaDV'and column_name != 'TrangThai'", connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu select được vào database dt
            cbotimkiem.DataSource = dt;
            cbotimkiem.DisplayMember = "column_name";
        }
        public void load_data()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from DICHVU", connect);
            DataSet ds = new DataSet();
            da1.Fill(ds, "dichvu");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "dichvu";

        }
        private void resetValues()
        {
            txtmadv.Clear();
            txttendv.Clear();
            txtloaidv.Clear();
            txtmota.Clear();
            rbtncon.Checked = default;
            txtdonvi.Clear();
            txtdongia.Clear();
        }
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = @"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            //đổ dữ liệu lên combobox
            SqlCommand cmd = new SqlCommand("select MaDV from DICHVU", connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // đổ dữ liệu select được vào database dt
            cbotimkiem.DataSource = dt;
            cbotimkiem.DisplayMember = "MaDV";
            load_Colum();
            load_data();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sqlCHECK = "Select count(*) MaDV from DICHVU where MaDV = @MaDV";
            SqlCommand cmdl = new SqlCommand(sqlCHECK, connect);
            cmdl.Parameters.AddWithValue(@"MaDV", txtmadv.Text);

            int val = (int)cmdl.ExecuteScalar();
            if (val > 0)
            {
                MessageBox.Show("Mã dịch vụ này đã tồn tại!");
            }
            else
            {

                string sqlINSERT = "INSERT INTO DICHVU values (@MaDV,@TenDV,@LoaiDV,@MoTaDV,@TrangThai,@SoLuong,@DonGia)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, connect);
                cmd.Parameters.AddWithValue("@MaDV", this.txtmadv.Text);
                cmd.Parameters.AddWithValue("@TenDV", this.txttendv.Text);
                cmd.Parameters.AddWithValue("@LoaiDV", this.txtloaidv.Text);
                cmd.Parameters.AddWithValue("@MoTaDV", this.txtmota.Text);
                if (rbtncon.Checked)
                {
                    cmd.Parameters.AddWithValue("@TrangThai", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TrangThai", false);
                }
                cmd.Parameters.AddWithValue("@SoLuong", this.txtdonvi.Text);
                cmd.Parameters.AddWithValue("@DonGia", this.txtdongia.Text);
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Thêm thành công");
                load_data();
                resetValues();
                txtmadv.Focus();
                if (connect.State == ConnectionState.Open)
                    connect.Close();
                frmDichVu_Load(sender, e);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int dongchon = this.dataGridView1.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand("Update DICHVU set MaDV=@MaDV,TenDV=@TenDV,LoaiDV=@LoaiDV,MoTaDV=@MoTaDV,TrangThai=@TrangThai,SoLuong=@SoLuong,DonGia=@DonGia where MaDV=@MaDV", connect);
            cmd.Parameters.AddWithValue("@MaDV", this.txtmadv.Text);
            cmd.Parameters.AddWithValue("@TenDV", this.txttendv.Text);
            cmd.Parameters.AddWithValue("@LoaiDV", this.txtloaidv.Text);
            cmd.Parameters.AddWithValue("@MoTaDV", this.txtmota.Text);
            if (rbtncon.Checked)
            {
                cmd.Parameters.AddWithValue("@TrangThai", true);
            }
            else
            {
                cmd.Parameters.AddWithValue("@TrangThai", false);
            }
            cmd.Parameters.AddWithValue("@SoLuong", this.txtdonvi.Text);
            cmd.Parameters.AddWithValue("@DonGia", this.txtdongia.Text);
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
            load_data();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa??", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM DICHVU WHERE MaDV = @MaDV", connect);
                    cmd.Parameters.AddWithValue("@MaDV", this.txtmadv.Text);
                    cmd.Parameters.AddWithValue("@TenDV", this.txttendv.Text);
                    cmd.Parameters.AddWithValue("@LoaiDV", this.txtloaidv.Text);
                    cmd.Parameters.AddWithValue("@MoTaDV", this.txtmota.Text);
                    if (rbtncon.Checked)
                    {
                        cmd.Parameters.AddWithValue("@TrangThai", true);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@TrangThai", false);
                    }
                    cmd.Parameters.AddWithValue("@SoLuong", this.txtdonvi.Text);
                    cmd.Parameters.AddWithValue("@DonGia", this.txtdongia.Text);
                    if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Xóa thành công");
                    else MessageBox.Show("Xóa thất bại");
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                    frmDichVu_Load(sender, e);
                    resetValues();

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

        private void btntimma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttimkiem.Text.Trim()))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cbotimkiem.Text == "SoLuong")
            {
                string strTimKiem = "SELECT * FROM DICHVU WHERE " + cbotimkiem.Text + " like '%" + Convert.ToInt32(txttimkiem.Text) + "%'";
                cmd = new SqlCommand(strTimKiem, connect);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else if (cbotimkiem.Text == "DonGia")
            {
                string strTimKiem = "SELECT * FROM DICHVU WHERE " + cbotimkiem.Text + " like '%" + Convert.ToDecimal(txttimkiem.Text) + "%'";
                cmd = new SqlCommand(strTimKiem, connect);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else
            {
                string strTimKiem = "SELECT * FROM DICHVU WHERE " + cbotimkiem.Text + " like N'%" + txttimkiem.Text + "%'";
                cmd = new SqlCommand(strTimKiem, connect);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
        }

        private void frmDichVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
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
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            resetValues();
            load_data();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                this.txtmadv.Text = dataGridView1.Rows[dongchon].Cells["MaDV"].Value.ToString();
                this.txttendv.Text = dataGridView1.Rows[dongchon].Cells["TenDV"].Value.ToString();
                this.txtloaidv.Text = dataGridView1.Rows[dongchon].Cells["LoaiDV"].Value.ToString();
                this.txtmota.Text = dataGridView1.Rows[dongchon].Cells["MoTaDV"].Value.ToString();
                if (Convert.ToBoolean(dataGridView1.Rows[dongchon].Cells["TrangThai"].Value) == true)
                {
                    rbtncon.Checked = true;
                }
                else
                {
                    rbtnhet.Checked = true;
                }
                this.txtdonvi.Text = dataGridView1.Rows[dongchon].Cells["SoLuong"].Value.ToString();
                this.txtdongia.Text = dataGridView1.Rows[dongchon].Cells["DonGia"].Value.ToString();
            }
        }
    }
}
