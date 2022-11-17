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
        public frmformMain()
        {
            InitializeComponent();
        }

        private void imageSaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýKháchSạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool _IsAtive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Đồ_án_1.frmDangnhaphethongnhanvien1))
                {
                    form.Activate();
                    _IsAtive = true;
                }
            }
            if (!_IsAtive)
            {
                frmDangnhaphethongnhanvien1 Pretest = new Đồ_án_1.frmDangnhaphethongnhanvien1();
                Pretest.MdiParent = this;
                Pretest.Show();
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoThốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trangThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool _IsAtive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Đồ_án_1.frmTrangThietBi))
                {
                    form.Activate();
                    _IsAtive = true;
                }
            }
            if (!_IsAtive)
            {
                Đồ_án_1.frmTrangThietBi Pretest = new Đồ_án_1.frmTrangThietBi();
                Pretest.MdiParent = this;
                Pretest.Show();
            }
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool _IsAtive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Đồ_án_1.frmNhanVien))
                {
                    form.Activate();
                    _IsAtive = true;
                }
            }
            if (!_IsAtive)
            {
                Đồ_án_1.frmNhanVien Pretest = new Đồ_án_1.frmNhanVien();
                Pretest.MdiParent = this;
                Pretest.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bool _IsAtive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Đồ_án_1.frmKhachHang))
                {
                    form.Activate();
                    _IsAtive = true;
                }
            }
            if (!_IsAtive)
            {
                Đồ_án_1.frmKhachHang Pretest = new Đồ_án_1.frmKhachHang();
                Pretest.MdiParent = this;
                Pretest.Show();
            }
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            bool _IsAtive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Đồ_án_1.frmHoaDon))
                {
                    form.Activate();
                    _IsAtive = true;
                }
            }
            if (!_IsAtive)
            {
                Đồ_án_1.frmHoaDon Pretest = new Đồ_án_1.frmHoaDon();
                Pretest.MdiParent = this;
                Pretest.Show();
            }
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool _IsAtive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Đồ_án_1.frmBaoCao))
                {
                    form.Activate();
                    _IsAtive = true;
                }
            }
            if (!_IsAtive)
            {
                Đồ_án_1.frmBaoCao Pretest = new Đồ_án_1.frmBaoCao();
                Pretest.MdiParent = this;
                Pretest.Show();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool _IsAtive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Đồ_án_1.frmDangkyhethongkhachhang))
                {
                    form.Activate();
                    _IsAtive = true;
                }
            }
            if (!_IsAtive)
            {
                Đồ_án_1.frmDangkyhethongkhachhang Pretest = new Đồ_án_1.frmDangkyhethongkhachhang();
                Pretest.MdiParent = this;
                Pretest.Show();
            }
        }

        private void dịchVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            bool _IsAtive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Đồ_án_1.frmDichVu))
                {
                    form.Activate();
                    _IsAtive = true;
                }
            }
            if (!_IsAtive)
            {
                Đồ_án_1.frmDichVu Pretest = new Đồ_án_1.frmDichVu();
                Pretest.MdiParent = this;
                Pretest.Show();
            }

        }

        private void dịchVụCóSẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void đăngKýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void trangThiếtBịToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void quảnLýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool _IsAtive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Đồ_án_1.frmDangnhaphethongquanly))
                {
                    form.Activate();
                    _IsAtive = true;
                }
            }
            if (!_IsAtive)
            {
                Đồ_án_1.frmDangnhaphethongquanly Pretest = new Đồ_án_1.frmDangnhaphethongquanly();
                Pretest.MdiParent = this;
                Pretest.Show();
            }
        }

        private void đăngKýĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool _IsAtive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Đồ_án_1.frmDangKyDatPhong))
                {
                    form.Activate();
                    _IsAtive = true;
                }
            }
            if (!_IsAtive)
            {
                Đồ_án_1.frmDangKyDatPhong Pretest = new Đồ_án_1.frmDangKyDatPhong();
                Pretest.MdiParent = this;
                Pretest.Show();
            }
        }

        private void yêuCầuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool _IsAtive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Đồ_án_1.frmDangkydichvu))
                {
                    form.Activate();
                    _IsAtive = true;
                }
            }
            if (!_IsAtive)
            {
                Đồ_án_1.frmDangkydichvu Pretest = new Đồ_án_1.frmDangkydichvu();
                Pretest.MdiParent = this;
                Pretest.Show();
            }
        }

        private void phòngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool _IsAtive = false;
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (form.GetType() == typeof(Đồ_án_1.frmPhong))
                {
                    form.Activate();
                    _IsAtive = true;
                }
            }
            if (!_IsAtive)
            {
                Đồ_án_1.frmPhong Pretest = new Đồ_án_1.frmPhong();
                Pretest.MdiParent = this;
                Pretest.Show();
            }
        }
    }
}
