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
    public partial class frmQLyTaiKhoan : Form
    {
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmQLyTaiKhoan()
        {
            InitializeComponent();
            connect = new SqlConnection(@"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
        }
        private void load_data()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select *from NGUOIDUNGHT";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void frmQLyTaiKhoan_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            txtloainguoidung.Text = "";
            txtpass.Text = "";
            txtuser.Text = "";
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
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                DataGridView_colorText();
                DataGridView_CentreHeaders();
            }
        }
        public bool kiemtra()
        {
            if (string.IsNullOrWhiteSpace(txtuser.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập tên user", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtuser.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtpass.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập mật khẩu user", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtpass.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtloainguoidung.Text.Trim()))
            {
                MessageBox.Show("Hãy nhập loại người dùng", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtloainguoidung.Focus();
                return false;
            }
            return true;
        }
        private void resetvalue()
        {
            txtuser.Clear();
            txtpass.Clear();
            txtloainguoidung.Clear();
            txttimkiem.Clear();
            txtuser.Focus();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                try
                {
                    string sqlINSERT = "Insert into NGUOIDUNGHT (UserName,Password,LoaiNguoiDung) values(@UserName,@Password,@LoaiNguoiDung)";
                    SqlCommand cmd = new SqlCommand(sqlINSERT, connect);
                    cmd.Parameters.AddWithValue("@UserName", this.txtuser.Text);
                    cmd.Parameters.AddWithValue("@Password", this.txtpass.Text);
                    cmd.Parameters.AddWithValue("@LoaiNguoiDung", this.txtloainguoidung.Text);

                    if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Add acount successful");
                    else MessageBox.Show("Add acount faild");
                    resetvalue();
                    load_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa???", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM NGUOIDUNGHT WHERE UserName = @UserName", connect);
                    cmd.Parameters.AddWithValue("@UserName", this.txtuser.Text);
                    cmd.Parameters.AddWithValue("@Password", this.txtpass.Text);
                    cmd.Parameters.AddWithValue("@LoaiNguoiDung", this.txtloainguoidung.Text);
                    if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Xóa thành công");
                    else MessageBox.Show("Xóa thất bại");
                    resetvalue();
                    load_data();

                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát chương trình này??", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (string.IsNullOrWhiteSpace(txttimkiem.Text.Trim()))
            {
                MessageBox.Show("Nhập điều kiện cần tìm kiếm");
            }
            sql = "SELECT * FROM NGUOIDUNGHT WHERE LoaiNguoiDung like N'%" + txttimkiem.Text + "%'"; ;
            cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetvalue();
            load_data();
        }

        private void frmQLyTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int dongchon = -1;
            dongchon = dataGridView1.CurrentRow.Index;
            if (dongchon >= 0)
            {
                this.txtuser.Text = dataGridView1.Rows[dongchon].Cells["UserName"].Value.ToString();
                this.txtpass.Text = dataGridView1.Rows[dongchon].Cells["Password"].Value.ToString();
                this.txtloainguoidung.Text = dataGridView1.Rows[dongchon].Cells["LoaiNguoiDung"].Value.ToString();
            }
        }
    }
}
