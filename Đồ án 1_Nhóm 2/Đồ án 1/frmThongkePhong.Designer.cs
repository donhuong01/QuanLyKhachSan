
namespace Đồ_án_1
{
    partial class frmThongkePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongkePhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 59);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(526, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DS PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.Location = new System.Drawing.Point(1110, 78);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(122, 44);
            this.btnthoat.TabIndex = 14;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthongke.Location = new System.Drawing.Point(959, 78);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(122, 44);
            this.btnthongke.TabIndex = 15;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = false;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.MintCream;
            this.reportViewer1.Location = new System.Drawing.Point(96, 139);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1136, 574);
            this.reportViewer1.TabIndex = 17;
            // 
            // frmThongkePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1302, 763);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongkePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê phòng thuê";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThongkePhong_FormClosed);
            this.Load += new System.EventHandler(this.frmThongkePhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnthongke;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}