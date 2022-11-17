
namespace Đồ_án_1
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LichHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnnu = new System.Windows.Forms.RadioButton();
            this.rbtnnam = new System.Windows.Forms.RadioButton();
            this.dtplichhen = new System.Windows.Forms.DateTimePicker();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtquoctich = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmaKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnrefesh = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtkhoa = new System.Windows.Forms.TextBox();
            this.cbotimkiem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(489, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(815, 653);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.CMND,
            this.EmailKH,
            this.SoDT,
            this.DiaChi,
            this.QuocTich,
            this.GioiTinh,
            this.LichHen});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 623);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.dataGridView1_VisibleChanged);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 125;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Họ tên KH";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 250;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.Width = 150;
            // 
            // EmailKH
            // 
            this.EmailKH.DataPropertyName = "EmailKH";
            this.EmailKH.HeaderText = "Email";
            this.EmailKH.MinimumWidth = 6;
            this.EmailKH.Name = "EmailKH";
            this.EmailKH.Width = 200;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 300;
            // 
            // QuocTich
            // 
            this.QuocTich.DataPropertyName = "QuocTich";
            this.QuocTich.HeaderText = "Quốc tịch";
            this.QuocTich.MinimumWidth = 6;
            this.QuocTich.Name = "QuocTich";
            this.QuocTich.Width = 225;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GioiTinh.Width = 125;
            // 
            // LichHen
            // 
            this.LichHen.DataPropertyName = "LichHen";
            this.LichHen.HeaderText = "Lịch hẹn";
            this.LichHen.MinimumWidth = 6;
            this.LichHen.Name = "LichHen";
            this.LichHen.Width = 200;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox3.Controls.Add(this.rbtnnu);
            this.groupBox3.Controls.Add(this.rbtnnam);
            this.groupBox3.Controls.Add(this.dtplichhen);
            this.groupBox3.Controls.Add(this.txtsdt);
            this.groupBox3.Controls.Add(this.txtquoctich);
            this.groupBox3.Controls.Add(this.txtcmnd);
            this.groupBox3.Controls.Add(this.txtdiachi);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtemail);
            this.groupBox3.Controls.Add(this.txthoten);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtmaKH);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Olive;
            this.groupBox3.Location = new System.Drawing.Point(873, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 469);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm Khách Hàng";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbtnnu
            // 
            this.rbtnnu.AutoSize = true;
            this.rbtnnu.Location = new System.Drawing.Point(268, 366);
            this.rbtnnu.Name = "rbtnnu";
            this.rbtnnu.Size = new System.Drawing.Size(50, 22);
            this.rbtnnu.TabIndex = 21;
            this.rbtnnu.TabStop = true;
            this.rbtnnu.Text = "Nữ";
            this.rbtnnu.UseVisualStyleBackColor = true;
            // 
            // rbtnnam
            // 
            this.rbtnnam.AutoSize = true;
            this.rbtnnam.Location = new System.Drawing.Point(158, 366);
            this.rbtnnam.Name = "rbtnnam";
            this.rbtnnam.Size = new System.Drawing.Size(64, 22);
            this.rbtnnam.TabIndex = 21;
            this.rbtnnam.TabStop = true;
            this.rbtnnam.Text = "Nam";
            this.rbtnnam.UseVisualStyleBackColor = true;
            // 
            // dtplichhen
            // 
            this.dtplichhen.Location = new System.Drawing.Point(161, 415);
            this.dtplichhen.Name = "dtplichhen";
            this.dtplichhen.Size = new System.Drawing.Size(293, 24);
            this.dtplichhen.TabIndex = 20;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(161, 226);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(293, 24);
            this.txtsdt.TabIndex = 13;
            // 
            // txtquoctich
            // 
            this.txtquoctich.Location = new System.Drawing.Point(161, 318);
            this.txtquoctich.Name = "txtquoctich";
            this.txtquoctich.Size = new System.Drawing.Size(293, 24);
            this.txtquoctich.TabIndex = 13;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(161, 131);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(293, 24);
            this.txtcmnd.TabIndex = 14;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(161, 268);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(293, 24);
            this.txtdiachi.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "Số DT";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(161, 178);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(293, 24);
            this.txtemail.TabIndex = 17;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(161, 83);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(293, 24);
            this.txthoten.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Lịch hẹn";
            // 
            // txtmaKH
            // 
            this.txtmaKH.Location = new System.Drawing.Point(161, 36);
            this.txtmaKH.Name = "txtmaKH";
            this.txtmaKH.Size = new System.Drawing.Size(293, 24);
            this.txtmaKH.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Quốc tịch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "CMND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Họ tên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Mã KH";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.btnrefesh);
            this.groupBox4.Controls.Add(this.btnxoa);
            this.groupBox4.Controls.Add(this.btnsua);
            this.groupBox4.Controls.Add(this.btnthem);
            this.groupBox4.Location = new System.Drawing.Point(873, 735);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 150);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btnrefesh
            // 
            this.btnrefesh.BackColor = System.Drawing.Color.Maroon;
            this.btnrefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefesh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrefesh.Location = new System.Drawing.Point(284, 88);
            this.btnrefesh.Name = "btnrefesh";
            this.btnrefesh.Size = new System.Drawing.Size(122, 43);
            this.btnrefesh.TabIndex = 0;
            this.btnrefesh.Text = "Refesh";
            this.btnrefesh.UseVisualStyleBackColor = false;
            this.btnrefesh.Click += new System.EventHandler(this.btnrefesh_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Maroon;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Location = new System.Drawing.Point(113, 88);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(122, 43);
            this.btnxoa.TabIndex = 0;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Maroon;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Location = new System.Drawing.Point(320, 21);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(122, 43);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Cập nhật";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Maroon;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthem.Location = new System.Drawing.Point(46, 21);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(122, 43);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.txtkhoa);
            this.groupBox1.Controls.Add(this.cbotimkiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1330, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm khách hàng";
            // 
            // btnthoat
            // 
            this.btnthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(1155, 33);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(134, 44);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntimkiem.Location = new System.Drawing.Point(968, 33);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(134, 44);
            this.btntimkiem.TabIndex = 7;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click_1);
            // 
            // txtkhoa
            // 
            this.txtkhoa.Location = new System.Drawing.Point(389, 73);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(485, 26);
            this.txtkhoa.TabIndex = 6;
            // 
            // cbotimkiem
            // 
            this.cbotimkiem.FormattingEnabled = true;
            this.cbotimkiem.Items.AddRange(new object[] {
            "Mã KH",
            "Tên KH",
            "Ngày đến - Ngày đi"});
            this.cbotimkiem.Location = new System.Drawing.Point(389, 30);
            this.cbotimkiem.Name = "cbotimkiem";
            this.cbotimkiem.Size = new System.Drawing.Size(485, 28);
            this.cbotimkiem.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập từ khóa tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 62);
            this.panel1.TabIndex = 8;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1406, 953);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKhachHang_FormClosed);
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtquoctich;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmaKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtplichhen;
        private System.Windows.Forms.RadioButton rbtnnu;
        private System.Windows.Forms.RadioButton rbtnnam;
        private System.Windows.Forms.Button btnrefesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocTich;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LichHen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtkhoa;
        private System.Windows.Forms.ComboBox cbotimkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}