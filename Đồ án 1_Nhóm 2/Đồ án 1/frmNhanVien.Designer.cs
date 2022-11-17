
namespace Đồ_án_1
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.lblquanlynhanvien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnrefesh = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.cbotimkem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTriLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnnu = new System.Windows.Forms.RadioButton();
            this.rbtnnam = new System.Windows.Forms.RadioButton();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtvitri = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtsodt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenbp = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblquanlynhanvien
            // 
            this.lblquanlynhanvien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblquanlynhanvien.AutoSize = true;
            this.lblquanlynhanvien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquanlynhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblquanlynhanvien.Location = new System.Drawing.Point(543, 9);
            this.lblquanlynhanvien.Name = "lblquanlynhanvien";
            this.lblquanlynhanvien.Size = new System.Drawing.Size(291, 37);
            this.lblquanlynhanvien.TabIndex = 0;
            this.lblquanlynhanvien.Text = "QUẢN LÝ NHÂN VIÊN";
            this.lblquanlynhanvien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.btnrefesh);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.cbotimkem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttukhoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhân viên";
            // 
            // btnrefesh
            // 
            this.btnrefesh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnrefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefesh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrefesh.Location = new System.Drawing.Point(637, 83);
            this.btnrefesh.Name = "btnrefesh";
            this.btnrefesh.Size = new System.Drawing.Size(109, 35);
            this.btnrefesh.TabIndex = 8;
            this.btnrefesh.Text = "Refesh";
            this.btnrefesh.UseVisualStyleBackColor = false;
            this.btnrefesh.Click += new System.EventHandler(this.btnrefesh_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntimkiem.Location = new System.Drawing.Point(637, 30);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(109, 36);
            this.btntimkiem.TabIndex = 7;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // cbotimkem
            // 
            this.cbotimkem.FormattingEnabled = true;
            this.cbotimkem.Location = new System.Drawing.Point(201, 43);
            this.cbotimkem.Name = "cbotimkem";
            this.cbotimkem.Size = new System.Drawing.Size(340, 26);
            this.cbotimkem.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ khóa tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // txttukhoa
            // 
            this.txttukhoa.Location = new System.Drawing.Point(201, 91);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(340, 24);
            this.txttukhoa.TabIndex = 5;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(250, 82);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(109, 36);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "Thoát";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(29, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(818, 557);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.UserName,
            this.TenNV,
            this.TenBP,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.Email,
            this.SoDT,
            this.ChucVu,
            this.ViTriLamViec});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 527);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.dataGridView1_VisibleChanged);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Username";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Họ Tên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 225;
            // 
            // TenBP
            // 
            this.TenBP.DataPropertyName = "TenBP";
            this.TenBP.HeaderText = "Tên BP";
            this.TenBP.MinimumWidth = 6;
            this.TenBP.Name = "TenBP";
            this.TenBP.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 135;
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
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 250;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 250;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.Width = 125;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 125;
            // 
            // ViTriLamViec
            // 
            this.ViTriLamViec.DataPropertyName = "ViTriLamViec";
            this.ViTriLamViec.HeaderText = "Vị trí làm việc";
            this.ViTriLamViec.MinimumWidth = 6;
            this.ViTriLamViec.Name = "ViTriLamViec";
            this.ViTriLamViec.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox3.Controls.Add(this.rbtnnu);
            this.groupBox3.Controls.Add(this.rbtnnam);
            this.groupBox3.Controls.Add(this.dtpngaysinh);
            this.groupBox3.Controls.Add(this.txtvitri);
            this.groupBox3.Controls.Add(this.txtchucvu);
            this.groupBox3.Controls.Add(this.txtemail);
            this.groupBox3.Controls.Add(this.txthoten);
            this.groupBox3.Controls.Add(this.txtsodt);
            this.groupBox3.Controls.Add(this.txtdiachi);
            this.groupBox3.Controls.Add(this.txttenbp);
            this.groupBox3.Controls.Add(this.txtuser);
            this.groupBox3.Controls.Add(this.txtmaNV);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(883, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 559);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm Nhân Viên mới";
            // 
            // rbtnnu
            // 
            this.rbtnnu.AutoSize = true;
            this.rbtnnu.Location = new System.Drawing.Point(275, 263);
            this.rbtnnu.Name = "rbtnnu";
            this.rbtnnu.Size = new System.Drawing.Size(50, 22);
            this.rbtnnu.TabIndex = 7;
            this.rbtnnu.TabStop = true;
            this.rbtnnu.Text = "Nữ";
            this.rbtnnu.UseVisualStyleBackColor = true;
            // 
            // rbtnnam
            // 
            this.rbtnnam.AutoSize = true;
            this.rbtnnam.Location = new System.Drawing.Point(152, 263);
            this.rbtnnam.Name = "rbtnnam";
            this.rbtnnam.Size = new System.Drawing.Size(64, 22);
            this.rbtnnam.TabIndex = 7;
            this.rbtnnam.TabStop = true;
            this.rbtnnam.Text = "Nam";
            this.rbtnnam.UseVisualStyleBackColor = true;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Location = new System.Drawing.Point(152, 219);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(232, 24);
            this.dtpngaysinh.TabIndex = 6;
            // 
            // txtvitri
            // 
            this.txtvitri.Location = new System.Drawing.Point(153, 494);
            this.txtvitri.Name = "txtvitri";
            this.txtvitri.Size = new System.Drawing.Size(232, 24);
            this.txtvitri.TabIndex = 5;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(153, 445);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(232, 24);
            this.txtchucvu.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(153, 349);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(232, 24);
            this.txtemail.TabIndex = 5;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(152, 130);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(232, 24);
            this.txthoten.TabIndex = 5;
            // 
            // txtsodt
            // 
            this.txtsodt.Location = new System.Drawing.Point(153, 394);
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(232, 24);
            this.txtsodt.TabIndex = 5;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(153, 306);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(232, 24);
            this.txtdiachi.TabIndex = 5;
            // 
            // txttenbp
            // 
            this.txttenbp.Location = new System.Drawing.Point(152, 172);
            this.txttenbp.Name = "txttenbp";
            this.txttenbp.Size = new System.Drawing.Size(232, 24);
            this.txttenbp.TabIndex = 5;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(153, 85);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(232, 24);
            this.txtuser.TabIndex = 5;
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(153, 42);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(232, 24);
            this.txtmaNV.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ngày sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Vị trí làm việc";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 451);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "Chức vụ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số ĐT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tên BP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã NV";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Linen;
            this.groupBox4.Controls.Add(this.btnxoa);
            this.groupBox4.Controls.Add(this.btnclose);
            this.groupBox4.Controls.Add(this.btnsua);
            this.groupBox4.Controls.Add(this.btnthem);
            this.groupBox4.Location = new System.Drawing.Point(883, 635);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 128);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(58, 82);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(109, 36);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.White;
            this.btnsua.Location = new System.Drawing.Point(250, 21);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(109, 36);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Cập nhật";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(58, 21);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 36);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1365, 801);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblquanlynhanvien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNhanVien_FormClosed);
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblquanlynhanvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.ComboBox cbotimkem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.TextBox txtsodt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenbp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbtnnu;
        private System.Windows.Forms.RadioButton rbtnnam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Button btnrefesh;
        private System.Windows.Forms.TextBox txtvitri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTriLamViec;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label4;
    }
}