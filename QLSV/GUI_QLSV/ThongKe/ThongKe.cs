using BUS_QLSV;
using DTO_QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GUI_QLSV
{
    public partial class Thống_kê : Form
    {
        private static BUS_SV bUS_SV = new BUS_SV();
        private static BUS_Diem bUS_Diem = new BUS_Diem();

        public Thống_kê()
        {
            InitializeComponent();
        }

        public void LoadDataSV()
        {
            dataGridView1.DataSource = bUS_SV.getTSV();
        }

        private void HeaderTextSV()
        {
            this.dataGridView1.Columns[0].HeaderText = "Mã";
            this.dataGridView1.Columns[1].HeaderText = "Họ Tên";
            this.dataGridView1.Columns[2].HeaderText = "CCCD";
            this.dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            this.dataGridView1.Columns[4].HeaderText = "Giới Tính";
            this.dataGridView1.Columns[5].HeaderText = "Quê";
            this.dataGridView1.Columns[6].HeaderText = "SĐT";
            this.dataGridView1.Columns[7].HeaderText = "Email";
            this.dataGridView1.Columns[8].HeaderText = "Trạng Thái";
            this.dataGridView1.Columns[9].HeaderText = "Mã Lớp";
        }

        private void SizeTextSV()
        {
            this.dataGridView1.Columns[0].Width = 130;
            this.dataGridView1.Columns[1].Width = 230;
            this.dataGridView1.Columns[2].Width = 140;
            this.dataGridView1.Columns[3].Width = 140;
            this.dataGridView1.Columns[4].Width = 120;
            this.dataGridView1.Columns[5].Width = 130;
            this.dataGridView1.Columns[6].Width = 150;
            this.dataGridView1.Columns[7].Width = 300;
            this.dataGridView1.Columns[8].Width = 150;
            this.dataGridView1.Columns[9].Width = 100;
        }

        private void HeaderTextDiem()
        {
            this.dataGridView1.Columns[0].HeaderText = "Mã";
            this.dataGridView1.Columns[1].HeaderText = "MSSV";
            this.dataGridView1.Columns[2].HeaderText = "Mã Môn Học";
            this.dataGridView1.Columns[3].HeaderText = "Giữa Kì";
            this.dataGridView1.Columns[4].HeaderText = "Cuối Kì";
            this.dataGridView1.Columns[5].HeaderText = "Hệ 10";
            this.dataGridView1.Columns[6].HeaderText = "Hệ 4";
            this.dataGridView1.Columns[7].HeaderText = "Loại";
        }

        private void SizeTextDiem()
        {
            this.dataGridView1.Columns[0].Width = 100;
            this.dataGridView1.Columns[1].Width = 130;
            this.dataGridView1.Columns[2].Width = 200;
            this.dataGridView1.Columns[3].Width = 150;
            this.dataGridView1.Columns[4].Width = 150;
            this.dataGridView1.Columns[5].Width = 120;
            this.dataGridView1.Columns[6].Width = 120;
            this.dataGridView1.Columns[7].Width = 120;
        }

        public float TinhHe4(float diem)
        {
            if (diem <= 10 && diem >= 8.5)
            {
                return 4;
            }
            if (diem <= 8.4 && diem >= 7)
            {
                return 3;
            }
            if (diem <= 6.9 && diem >= 5.5)
            {
                return 2;
            }
            if (diem <= 5.4 && diem >= 4)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public string Loai(float diem)
        {
            if (diem <= 10 && diem >= 9.0)
            {
                return "A+";
            }
            if (diem < 9.0 && diem >= 8.5)
            {
                return "A";
            }
            if (diem < 8.5 && diem >= 8.0)
            {
                return "B+";
            }
            if (diem < 8.0 && diem >= 7.0)
            {
                return "B";
            }
            if (diem < 7.0 && diem >= 6.5)
            {
                return "C+";
            }
            if (diem < 6.5 && diem >= 5.5)
            {
                return "C";
            }
            if (diem < 5.5 && diem >= 5.0)
            {
                return "D+";
            }
            if (diem < 5.0 && diem >= 4.0)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        private void Thống_kê_Load(object sender, EventArgs e)
        {
            if (TrangChu.cbb == "Sinh Viên")
            {
                dataGridView1.DataSource = bUS_Diem.getTDiemByMSSV(TrangChu.ms);
                HeaderTextDiem();
                SizeTextDiem();

                DataRow tb = bUS_Diem.getTDiemTBByMSSV(TrangChu.ms).Rows[0];
                lbDiemhe10.Text = tb["Column1"].ToString();

                float he10 = float.Parse(lbDiemhe10.Text);
                lbDiemHe4.Text = TinhHe4(he10).ToString();
                lbLoai.Text = Loai(he10);

                smiQLDiem.Visible = false;
                smiQLGV.Visible = false;
                smiQLLop.Visible = false;
                smiQLSV.Visible = false;
            }
            else { LoadDataSV();
                HeaderTextSV();
                SizeTextSV();
                lbLoai.Visible = false;
                lbDiemHe4.Visible = false;
                lbDiemhe10.Visible = false;
                label2.Visible = false;
                label5.Visible = false;
                label7.Visible = false;
                groupBox1.Visible = false;
            }
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diem diem = new Diem();
            diem.ShowDialog();
            this.Close();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinhVien sinhVien = new SinhVien();
            sinhVien.ShowDialog();
            this.Close();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giảng_viên giang_Vien = new Giảng_viên();
            giang_Vien.ShowDialog();
            this.Close();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lop lop = new Lop();
            lop.ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void smiTrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();
        }

    }
}
