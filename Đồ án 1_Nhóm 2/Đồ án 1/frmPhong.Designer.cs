
namespace Đồ_án_1
{
    partial class frmPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtntrong = new System.Windows.Forms.RadioButton();
            this.rbtnthue = new System.Windows.Forms.RadioButton();
            this.cboloaiphong = new System.Windows.Forms.ComboBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvitri = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnrefesh = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTriPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MoTaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.cbotimkiem = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.rbtntrong);
            this.groupBox1.Controls.Add(this.rbtnthue);
            this.groupBox1.Controls.Add(this.cboloaiphong);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtvitri);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttenphong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmaphong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(55, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin quản lý";
            // 
            // rbtntrong
            // 
            this.rbtntrong.AutoSize = true;
            this.rbtntrong.Location = new System.Drawing.Point(456, 236);
            this.rbtntrong.Name = "rbtntrong";
            this.rbtntrong.Size = new System.Drawing.Size(104, 22);
            this.rbtntrong.TabIndex = 9;
            this.rbtntrong.TabStop = true;
            this.rbtntrong.Text = "Còn trống";
            this.rbtntrong.UseVisualStyleBackColor = true;
            // 
            // rbtnthue
            // 
            this.rbtnthue.AutoSize = true;
            this.rbtnthue.Location = new System.Drawing.Point(270, 236);
            this.rbtnthue.Name = "rbtnthue";
            this.rbtnthue.Size = new System.Drawing.Size(87, 22);
            this.rbtnthue.TabIndex = 9;
            this.rbtnthue.TabStop = true;
            this.rbtnthue.Text = "Đã thuê";
            this.rbtnthue.UseVisualStyleBackColor = true;
            // 
            // cboloaiphong
            // 
            this.cboloaiphong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboloaiphong.FormattingEnabled = true;
            this.cboloaiphong.Items.AddRange(new object[] {
            "Loại 1",
            "Loại 2",
            "Loại 3"});
            this.cboloaiphong.Location = new System.Drawing.Point(270, 117);
            this.cboloaiphong.Name = "cboloaiphong";
            this.cboloaiphong.Size = new System.Drawing.Size(504, 26);
            this.cboloaiphong.TabIndex = 3;
            // 
            // txtdongia
            // 
            this.txtdongia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdongia.Location = new System.Drawing.Point(270, 312);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(504, 24);
            this.txtdongia.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Trạng thái";
            // 
            // txtmota
            // 
            this.txtmota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmota.Location = new System.Drawing.Point(270, 273);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(504, 24);
            this.txtmota.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mô tả phòng";
            // 
            // txtvitri
            // 
            this.txtvitri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtvitri.Location = new System.Drawing.Point(270, 156);
            this.txtvitri.Name = "txtvitri";
            this.txtvitri.Size = new System.Drawing.Size(504, 24);
            this.txtvitri.TabIndex = 4;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsoluong.Location = new System.Drawing.Point(270, 192);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(504, 24);
            this.txtsoluong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Vị trí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại phòng";
            // 
            // txttenphong
            // 
            this.txttenphong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttenphong.Location = new System.Drawing.Point(270, 76);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(504, 24);
            this.txttenphong.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phòng";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmaphong.Location = new System.Drawing.Point(270, 39);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(504, 24);
            this.txtmaphong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.btnrefesh);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(944, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 346);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnrefesh
            // 
            this.btnrefesh.BackColor = System.Drawing.Color.Maroon;
            this.btnrefesh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrefesh.Location = new System.Drawing.Point(43, 28);
            this.btnrefesh.Name = "btnrefesh";
            this.btnrefesh.Size = new System.Drawing.Size(147, 37);
            this.btnrefesh.TabIndex = 0;
            this.btnrefesh.Text = "Refesh";
            this.btnrefesh.UseVisualStyleBackColor = false;
            this.btnrefesh.Click += new System.EventHandler(this.btnrefesh_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Maroon;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(43, 289);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(147, 39);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Maroon;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Location = new System.Drawing.Point(43, 225);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(147, 39);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Maroon;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Location = new System.Drawing.Point(43, 157);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(147, 39);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Maroon;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthem.Location = new System.Drawing.Point(43, 91);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(147, 39);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(482, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "QUẢN LÝ PHÒNG";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(55, 501);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(1127, 332);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển thị";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.LoaiPhong,
            this.ViTriPhong,
            this.SoLuong,
            this.TinhTrang,
            this.MoTaPhong,
            this.DonGia});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.dataGridView1_VisibleChanged);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 125;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 155;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiPhong.Width = 125;
            // 
            // ViTriPhong
            // 
            this.ViTriPhong.DataPropertyName = "ViTriPhong";
            this.ViTriPhong.HeaderText = "Vị trí phòng";
            this.ViTriPhong.MinimumWidth = 6;
            this.ViTriPhong.Name = "ViTriPhong";
            this.ViTriPhong.Width = 225;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TinhTrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TinhTrang.Width = 150;
            // 
            // MoTaPhong
            // 
            this.MoTaPhong.DataPropertyName = "MoTaPhong";
            this.MoTaPhong.HeaderText = "Mô tả phòng";
            this.MoTaPhong.MinimumWidth = 6;
            this.MoTaPhong.Name = "MoTaPhong";
            this.MoTaPhong.Width = 300;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 200;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(52, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tìm kiếm phòng theo:";
            // 
            // txttukhoa
            // 
            this.txttukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txttukhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttukhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txttukhoa.Location = new System.Drawing.Point(688, 454);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(288, 24);
            this.txttukhoa.TabIndex = 6;
            // 
            // cbotimkiem
            // 
            this.cbotimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbotimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotimkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbotimkiem.FormattingEnabled = true;
            this.cbotimkiem.Location = new System.Drawing.Point(249, 452);
            this.cbotimkiem.Name = "cbotimkiem";
            this.cbotimkiem.Size = new System.Drawing.Size(237, 26);
            this.cbotimkiem.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(550, 460);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Từ khóa tìm:";
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.Maroon;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.Color.White;
            this.btntimkiem.Location = new System.Drawing.Point(1045, 445);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(132, 38);
            this.btntimkiem.TabIndex = 9;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 54);
            this.panel1.TabIndex = 10;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1253, 863);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbotimkiem);
            this.Controls.Add(this.txttukhoa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPhong_FormClosed);
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboloaiphong;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtvitri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnrefesh;
        private System.Windows.Forms.RadioButton rbtntrong;
        private System.Windows.Forms.RadioButton rbtnthue;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTriPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.ComboBox cbotimkiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Panel panel1;
    }
}