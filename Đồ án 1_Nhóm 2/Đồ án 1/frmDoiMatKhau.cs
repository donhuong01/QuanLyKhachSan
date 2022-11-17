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
using System.Configuration;

namespace Đồ_án_1
{
    public partial class frmDoiMatKhau : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public frmDoiMatKhau()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
        }
        private void set_lableandpicture()
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;
        }
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            set_lableandpicture();
            this.KeyPreview = true;
            this.KeyDown += btndoi_KeyDown;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btndoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btndoi_Click(sender, e);
            }
        }
        public bool KiemTra()
        {
            if (string.IsNullOrWhiteSpace(txtmkht.Text) && string.IsNullOrWhiteSpace(txtmkms.Text) && string.IsNullOrWhiteSpace(txtmkxn.Text))
            {
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Vui lòng nhập đầy đủ thông tin !!";
                lblShowInfor.Visible = true;
                txtmkht.Focus();
                return false;
            }
            else if (txtmkht.Text == "")
            {
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu hiện tại !!";
                lblShowInfor.Visible = true;
                txtmkht.Focus();
                return false;
            }
            else if (txtmkms.Text == "")
            {
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu mới !!";
                lblShowInfor.Visible = true;
                txtmkms.Focus();
                return false;
            }
            else if (txtmkxn.Text == "")
            {
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Vui lòng xác nhận mật khẩu !!";
                lblShowInfor.Visible = true;
                txtmkxn.Focus();
                return false;
            }
            else if (txtmkms.Text != txtmkxn.Text)
            {
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Mật khẩu mới và mật khẩu xác nhận không trùng khớp";
                lblShowInfor.Visible = true;
                txtmkxn.Focus();
                txtmkxn.SelectAll();
                return false;
            }
            return true;
        }
        private void btndoi_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                try
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "Select * from NGUOIDUNGHT";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Update_password";
                    cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txttentk.Text;
                    cmd.Parameters.Add("@OldPass", SqlDbType.NChar).Value = txtmkht.Text;
                    cmd.Parameters.Add("@NewPass", SqlDbType.NChar).Value = txtmkms.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.GetInt32(0) == 1)
                    {
                        lblShowInfor.ForeColor = Color.Blue;
                        lblShowInfor.Text = dr.GetString(1);
                        txtmkxn.Text = "";
                        txtmkht.Text = "";
                        txtmkms.Text = "";
                        txtmkht.Focus();
                    }
                    else
                    {
                        lblShowInfor.ForeColor = Color.Red;
                        lblShowInfor.Text = dr.GetString(1);
                        txtmkht.Focus();
                        txtmkht.SelectAll();
                    }
                    DialogResult ret = MessageBox.Show("Bạn có muốn đăng nhập lại hay không!!", "Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (ret == DialogResult.OK)
                    {
                        frmDangnhaphethongnhanvien1 open = new frmDangnhaphethongnhanvien1();
                        open.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmformMain open_formmain = new frmformMain();
                        open_formmain.Show();
                        this.Hide();
                    }
                    dr.Close();
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void frmDoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
       
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                frmformMain open_form = new frmformMain();
                open_form.Show();
                this.Hide();
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtmkht.PasswordChar = (char)0;
                txtmkms.PasswordChar = (char)0;
                txtmkxn.PasswordChar = (char)0;
            }
            else
            {
                txtmkht.PasswordChar = '*';
                txtmkms.PasswordChar = '*';
                txtmkxn.PasswordChar = '*';
            }
        }
    }
}
