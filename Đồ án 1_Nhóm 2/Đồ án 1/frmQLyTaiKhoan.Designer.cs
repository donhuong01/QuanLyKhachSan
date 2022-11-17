
namespace Đồ_án_1
{
    partial class frmQLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLyTaiKhoan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnex = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.txtloainguoidung = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 66);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(356, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounts Manager Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.btnex);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btndel);
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(44, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 246);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.Color.Maroon;
            this.btnex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnex.Location = new System.Drawing.Point(26, 197);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(175, 40);
            this.btnex.TabIndex = 2;
            this.btnex.Text = "Exit application";
            this.btnex.UseVisualStyleBackColor = false;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(26, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refesh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Maroon;
            this.btndel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndel.Location = new System.Drawing.Point(26, 86);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(175, 40);
            this.btndel.TabIndex = 1;
            this.btndel.Text = "Delete account";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Maroon;
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(26, 29);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(175, 40);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add account";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.Maroon;
            this.btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfind.Location = new System.Drawing.Point(710, 177);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(95, 40);
            this.btnfind.TabIndex = 3;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox3.Controls.Add(this.btnfind);
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Controls.Add(this.txtloainguoidung);
            this.groupBox3.Controls.Add(this.txtuser);
            this.groupBox3.Controls.Add(this.txtpass);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(302, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(811, 246);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin quản lý";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(325, 184);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(359, 24);
            this.txttimkiem.TabIndex = 5;
            // 
            // txtloainguoidung
            // 
            this.txtloainguoidung.Location = new System.Drawing.Point(230, 136);
            this.txtloainguoidung.Name = "txtloainguoidung";
            this.txtloainguoidung.Size = new System.Drawing.Size(454, 24);
            this.txtloainguoidung.TabIndex = 5;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(230, 43);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(454, 24);
            this.txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(230, 89);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(454, 24);
            this.txtpass.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tìm kiếm theo loại người dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại Người Dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(43, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.groupBox1.Size = new System.Drawing.Size(1070, 348);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Password,
            this.LoaiNguoiDung});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.dataGridView1_VisibleChanged);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Username";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 250;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 250;
            // 
            // LoaiNguoiDung
            // 
            this.LoaiNguoiDung.DataPropertyName = "LoaiNguoiDung";
            this.LoaiNguoiDung.HeaderText = "Loại người dùng";
            this.LoaiNguoiDung.MinimumWidth = 6;
            this.LoaiNguoiDung.Name = "LoaiNguoiDung";
            this.LoaiNguoiDung.Width = 400;
            // 
            // frmQLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 722);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQLyTaiKhoan_FormClosed);
            this.Load += new System.EventHandler(this.frmQLyTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtloainguoidung;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiNguoiDung;
    }
}