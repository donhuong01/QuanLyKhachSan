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
using Microsoft.Reporting.WinForms;

namespace Đồ_án_1
{
    public partial class frmThongkePhong : Form
    {
        SqlConnection connect;
        public frmThongkePhong()
        {
            InitializeComponent();
            connect = new SqlConnection(@"Data Source=THUY-NHUONG\THUYNHUONG;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
        }

        private void frmThongkePhong_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select *from HOADON_PHONG", connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "rptThongKePhong.rdlc";
            //Tạo nguồn dữ liệu cho báo cáo
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsPhongtheoHD";
            rds.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát chương trình này??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmThongkePhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }
        }
    }
}
