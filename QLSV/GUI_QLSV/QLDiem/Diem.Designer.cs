namespace GUI_QLSV
{
    partial class Diem
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labid = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.cbbGK = new System.Windows.Forms.ComboBox();
            this.cbbCK = new System.Windows.Forms.ComboBox();
            this.cbbMH = new System.Windows.Forms.ComboBox();
            this.txtGK = new System.Windows.Forms.TextBox();
            this.txtCK = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smiTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQlSV = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQLGV = new System.Windows.Forms.ToolStripMenuItem();
            this.smiQLLop = new System.Windows.Forms.ToolStripMenuItem();
            this.smiThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(340, 366);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 32);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.Text = "Nhập mã sinh viên";
            
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 29);
            this.label11.TabIndex = 28;
            this.label11.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.labid);
            this.groupBox1.Controls.Add(this.lbid);
            this.groupBox1.Controls.Add(this.cbbGK);
            this.groupBox1.Controls.Add(this.cbbCK);
            this.groupBox1.Controls.Add(this.cbbMH);
            this.groupBox1.Controls.Add(this.txtGK);
            this.groupBox1.Controls.Add(this.txtCK);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(232, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1099, 200);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // labid
            // 
            this.labid.AutoSize = true;
            this.labid.Location = new System.Drawing.Point(976, 68);
            this.labid.Name = "labid";
            this.labid.Size = new System.Drawing.Size(75, 29);
            this.labid.TabIndex = 17;
            this.labid.Text = "label5";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(985, 22);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(39, 29);
            this.lbid.TabIndex = 17;
            this.lbid.Text = "id:";
            // 
            // cbbGK
            // 
            this.cbbGK.FormattingEnabled = true;
            this.cbbGK.Location = new System.Drawing.Point(239, 141);
            this.cbbGK.Name = "cbbGK";
            this.cbbGK.Size = new System.Drawing.Size(278, 37);
            this.cbbGK.TabIndex = 16;
            // 
            // cbbCK
            // 
            this.cbbCK.FormattingEnabled = true;
            this.cbbCK.Location = new System.Drawing.Point(691, 139);
            this.cbbCK.Name = "cbbCK";
            this.cbbCK.Size = new System.Drawing.Size(267, 37);
            this.cbbCK.TabIndex = 16;
            // 
            // cbbMH
            // 
            this.cbbMH.FormattingEnabled = true;
            this.cbbMH.Location = new System.Drawing.Point(239, 35);
            this.cbbMH.Name = "cbbMH";
            this.cbbMH.Size = new System.Drawing.Size(278, 37);
            this.cbbMH.TabIndex = 16;
            // 
            // txtGK
            // 
            this.txtGK.Location = new System.Drawing.Point(239, 89);
            this.txtGK.Name = "txtGK";
            this.txtGK.Size = new System.Drawing.Size(278, 36);
            this.txtGK.TabIndex = 14;
            // 
            // txtCK
            // 
            this.txtCK.Location = new System.Drawing.Point(691, 89);
            this.txtCK.Name = "txtCK";
            this.txtCK.Size = new System.Drawing.Size(267, 36);
            this.txtCK.TabIndex = 11;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(691, 35);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(267, 36);
            this.txtMSSV.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "% Giữa kì:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "% Cuối kì:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Điểm giữa kì:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Điểm cuối kì:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "MSSV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã MH:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1560, 82);
            this.label1.TabIndex = 25;
            this.label1.Text = "QUẢN LÝ ĐIỂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiTrangChu,
            this.smiQlSV,
            this.smiQLGV,
            this.smiQLLop,
            this.smiThongKe,
            this.msiDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1560, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smiTrangChu
            // 
            this.smiTrangChu.Name = "smiTrangChu";
            this.smiTrangChu.Size = new System.Drawing.Size(89, 24);
            this.smiTrangChu.Text = "Trang Chủ";
            this.smiTrangChu.Click += new System.EventHandler(this.quảnLýĐiểmToolStripMenuItem_Click);
            // 
            // smiQlSV
            // 
            this.smiQlSV.Name = "smiQlSV";
            this.smiQlSV.Size = new System.Drawing.Size(140, 24);
            this.smiQlSV.Text = "Quản Lý Sinh Viên";
            this.smiQlSV.Click += new System.EventHandler(this.quảnLýSinhViênToolStripMenuItem_Click);
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
            // smiThongKe
            // 
            this.smiThongKe.Name = "smiThongKe";
            this.smiThongKe.Size = new System.Drawing.Size(86, 24);
            this.smiThongKe.Text = "Thống Kê";
            this.smiThongKe.Click += new System.EventHandler(this.smiThongKe_Click);
            // 
            // msiDangXuat
            // 
            this.msiDangXuat.Name = "msiDangXuat";
            this.msiDangXuat.Size = new System.Drawing.Size(93, 24);
            this.msiDangXuat.Text = "Đăng Xuất";
            this.msiDangXuat.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 313);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(232, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1111, 367);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // btThoat
            // 
            this.btThoat.Image = global::GUI_QLSV.Properties.Resources.Close;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(1157, 355);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(126, 48);
            this.btThoat.TabIndex = 34;
            this.btThoat.Text = "Đóng";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = global::GUI_QLSV.Properties.Resources.Delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(1012, 354);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(116, 48);
            this.btXoa.TabIndex = 33;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Image = global::GUI_QLSV.Properties.Resources.Update;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(875, 354);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(117, 48);
            this.btSua.TabIndex = 32;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Image = global::GUI_QLSV.Properties.Resources.Add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(729, 355);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(128, 48);
            this.btThem.TabIndex = 31;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSearch
            // 
            this.btSearch.Image = global::GUI_QLSV.Properties.Resources.Find;
            this.btSearch.Location = new System.Drawing.Point(625, 360);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(41, 38);
            this.btSearch.TabIndex = 30;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1560, 806);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Diem";
            this.Text = "Quản lý điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Diem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGK;
        private System.Windows.Forms.TextBox txtCK;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smiTrangChu;
        private System.Windows.Forms.ToolStripMenuItem smiQlSV;
        private System.Windows.Forms.ToolStripMenuItem smiQLGV;
        private System.Windows.Forms.ToolStripMenuItem smiQLLop;
        private System.Windows.Forms.ToolStripMenuItem msiDangXuat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbMH;
        private System.Windows.Forms.Label labid;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.ComboBox cbbGK;
        private System.Windows.Forms.ComboBox cbbCK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem smiThongKe;
    }
}