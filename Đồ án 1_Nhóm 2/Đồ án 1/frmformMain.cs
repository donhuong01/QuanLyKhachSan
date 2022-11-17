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
    public partial class frmformMain : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
        public frmformMain()
        {
            InitializeComponent();
        }
        
        private void frmformMain_Load(object sender, EventArgs e)
        {
            if (Program.loainguoidung == 1)
            {
                menuStrip1.Enabled = true;
            }
            else if (Program.loainguoidung == 2)
            {
                quảnLýNhânViênToolStripMenuItem.Enabled = false;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
            }
            else if (Program.loainguoidung == 3)
            {
                nhânViênToolStripMenuItem.Enabled = false;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
            }
        }
        
        private void nhânViênToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmNhanVien open_qlNV = new frmNhanVien(); //Khởi tạo đối tượng
            open_qlNV.Show(); //Hiển thị
        }

        private void kháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmKhachHang open_qlKH = new frmKhachHang();
            open_qlKH.Show();
        }

        private void dịchVụToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDichVu open_qlDV = new frmDichVu();
            open_qlDV.Show();
        }

        private void phòngToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmPhong open_qlPhong = new frmPhong();
            open_qlPhong.Show();
        }


        private void báoCáoThốngKêToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmformMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinNV open_frmTTNV = new frmThongTinNV();
            open_frmTTNV.Show();
        }

        private void lịchLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlichlamviec open_frmlich = new frmlichlamviec();
            open_frmlich.Show();
        }

        private void báoCáoChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChamCong open_frmCC = new frmChamCong();
            open_frmCC.Show();
        }

        private void bảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBangLuong open_frmBL = new frmBangLuong();
            open_frmBL.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangnhaphethongnhanvien1 open_frmdangnhap = new frmDangnhaphethongnhanvien1();
            open_frmdangnhap.Show();
            this.Hide();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau open_doimk = new frmDoiMatKhau();
            open_doimk.Show();
            this.Hide();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLyTaiKhoan open_frmqltk = new frmQLyTaiKhoan();
            open_frmqltk.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHoaDonKH open_BC = new frmHoaDonKH();
            open_BC.Show();
        }

        private void hóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonDV open_BC = new frmHoaDonDV();
            open_BC.Show();
        }

        private void hóaĐơnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongkePhong open_phong = new frmThongkePhong();
            open_phong.Show();
        }
    }
}
