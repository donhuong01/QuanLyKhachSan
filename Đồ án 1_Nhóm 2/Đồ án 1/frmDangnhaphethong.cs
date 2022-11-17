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
    public partial class frmDangnhaphethongnhanvien1 : Form
    {
        SqlConnection conn;
        public frmDangnhaphethongnhanvien1()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void set_lableandpicture()
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;
        }
        private void frmDangnhaphethongnhanvien1_Load(object sender, EventArgs e)
        {
            set_lableandpicture();
            conn = new SqlConnection(@"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            this.KeyPreview = true;
            this.KeyDown += btndangnhap_KeyDown;
        }

        public bool kiemtra()
        {
            if (String.IsNullOrEmpty(txtname.Text.Trim()))
            {
                MessageBox.Show("Please enter username!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtname.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtmatkhau.Text.Trim()))
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtmatkhau.Focus();
                return false;
            }
            return true;
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                try
                {
                    conn.Open();
                    string name = txtname.Text;
                    string mk = txtmatkhau.Text;
                    string sql = "select * from NGUOIDUNGHT where UserName = '" + name + "' and Password = '" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        MessageBox.Show("Login successful ");
                        if (name == "admin" || name =="admin01"||name=="admin02"||name=="admin03")
                        {
                            Program.loainguoidung = 1;
                            frmformMain open_formmain = new frmformMain();
                            open_formmain.Show();
                            this.Hide();
                        }
                        else if (name == "nhanvien"||name == "nhanvien01" || name == "nhanvien02" || name == "nhanvien03")
                        {
                            Program.loainguoidung = 2;
                            frmformMain open_formmain = new frmformMain();
                            open_formmain.Show();
                            this.Hide();
                        }
                        else if (name == "quanly" || name == "quanly01" || name == "quanly02" || name == "quanly03")
                        {
                            Program.loainguoidung = 3;
                            frmformMain open_formmain = new frmformMain();
                            open_formmain.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản không hợp lệ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login faild ");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi kết nối ");
                }
            }
            else
            {
                MessageBox.Show("Username or Password faild");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openFileDialog1.Filter = "RichText File|*.rtf";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc muốn thoát không (Do you sure you want to exit)?", "Exit??", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btndangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btndangnhap_Click(sender, e);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhienthi.Checked)
            {
                txtmatkhau.PasswordChar = (char)0;
            }
            else
            {
                txtmatkhau.PasswordChar = '*';
            }
        }

        private void frmDangnhaphethongnhanvien1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
