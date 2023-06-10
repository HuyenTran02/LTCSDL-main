namespace GUI_QLSV
{
    partial class Thống_kê
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
            this.components = new System.ComponentModel.Container();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smiTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQLSV = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQLGV = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQLLop = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQLDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbDiemhe10 = new System.Windows.Forms.Label();
            this.lbDiemHe4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbLoai = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btDong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(764, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 29);
            this.label11.TabIndex = 68;
            this.label11.Text = "Tìm kiếm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiTrangChu,
            this.smiQLSV,
            this.smiQLGV,
            this.smiQLLop,
            this.smiQLDiem,
            this.smiDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1462, 28);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smiTrangChu
            // 
            this.smiTrangChu.Name = "smiTrangChu";
            this.smiTrangChu.Size = new System.Drawing.Size(89, 24);
            this.smiTrangChu.Text = "Trang Chủ";
            this.smiTrangChu.Click += new System.EventHandler(this.smiTrangChu_Click);
            // 
            // smiQLSV
            // 
            this.smiQLSV.Name = "smiQLSV";
            this.smiQLSV.Size = new System.Drawing.Size(140, 24);
            this.smiQLSV.Text = "Quản Lý Sinh Viên";
            this.smiQLSV.Click += new System.EventHandler(this.quảnLýSinhViênToolStripMenuItem_Click);
            // 
            // smiQLGV
            // 
            this.smiQLGV.Name = "smiQLGV";
            this.smiQLGV.Size = new System.Drawing.Size(151, 24);
            this.smiQLGV.Text = "Quản Lý Giảng Viên";
            this.smiQLGV.Click += new System.EventHandler(this.quảnLýGiảngViênToolStripMenuItem_Click);
            // 
            // smiQLLop
            // 
            this.smiQLLop.Name = "smiQLLop";
            this.smiQLLop.Size = new System.Drawing.Size(104, 24);
            this.smiQLLop.Text = "Quản Lý Lớp";
            this.smiQLLop.Click += new System.EventHandler(this.quảnLýLớpToolStripMenuItem_Click);
            // 
            // smiQLDiem
            // 
            this.smiQLDiem.Name = "smiQLDiem";
            this.smiQLDiem.Size = new System.Drawing.Size(115, 24);
            this.smiQLDiem.Text = "Quản Lý Điểm";
            this.smiQLDiem.Click += new System.EventHandler(this.quảnLýĐiểmToolStripMenuItem_Click);
            // 
            // smiDangXuat
            // 
            this.smiDangXuat.Name = "smiDangXuat";
            this.smiDangXuat.Size = new System.Drawing.Size(91, 24);
            this.smiDangXuat.Text = "Đăng xuất";
            this.smiDangXuat.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(75, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1375, 616);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1335, 562);
            this.dataGridView1.TabIndex = 0;
            // 
            // diemBindingSource
            // 
            this.diemBindingSource.DataMember = "Diem";
            // 
            // lbDiemhe10
            // 
            this.lbDiemhe10.AutoSize = true;
            this.lbDiemhe10.BackColor = System.Drawing.Color.White;
            this.lbDiemhe10.Location = new System.Drawing.Point(199, 23);
            this.lbDiemhe10.Name = "lbDiemhe10";
            this.lbDiemhe10.Size = new System.Drawing.Size(75, 29);
            this.lbDiemhe10.TabIndex = 77;
            this.lbDiemhe10.Text = "label2";
            // 
            // lbDiemHe4
            // 
            this.lbDiemHe4.AutoSize = true;
            this.lbDiemHe4.BackColor = System.Drawing.Color.White;
            this.lbDiemHe4.Location = new System.Drawing.Point(399, 23);
            this.lbDiemHe4.Name = "lbDiemHe4";
            this.lbDiemHe4.Size = new System.Drawing.Size(75, 29);
            this.lbDiemHe4.TabIndex = 77;
            this.lbDiemHe4.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 78;
            this.label5.Text = "Điểm Hệ 4:";
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.BackColor = System.Drawing.Color.White;
            this.lbLoai.Location = new System.Drawing.Point(531, 23);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(75, 29);
            this.lbLoai.TabIndex = 77;
            this.lbLoai.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 29);
            this.label7.TabIndex = 78;
            this.label7.Text = "Loại:";
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(1318, 744);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(94, 41);
            this.btDong.TabIndex = 79;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 78;
            this.label2.Text = "Điểm Hệ 10:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbLoai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbDiemhe10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbDiemHe4);
            this.groupBox1.Location = new System.Drawing.Point(689, 727);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 66);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng Kết";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(0, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1462, 74);
            this.label4.TabIndex = 81;
            this.label4.Text = "THỐNG KÊ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Thống_kê
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1462, 830);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Thống_kê";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Thống_kê_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smiQLDiem;
        private System.Windows.Forms.ToolStripMenuItem smiQLSV;
        private System.Windows.Forms.ToolStripMenuItem smiQLGV;
        private System.Windows.Forms.ToolStripMenuItem smiQLLop;
        private System.Windows.Forms.ToolStripMenuItem smiTrangChu;
        private System.Windows.Forms.ToolStripMenuItem smiDangXuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.BindingSource diemBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbDiemhe10;
        private System.Windows.Forms.Label lbDiemHe4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}