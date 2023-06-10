using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLSV;
using BUS_QLSV;

namespace GUI_QLSV
{
    public partial class TrangChu : Form
    {
        public static string ms = "";
        public static string cbb = "";
        public static string ten = "";

        private static BUS_SV bUS_SV = new BUS_SV();
        private static BUS_Diem bUS_Diem = new BUS_Diem();
        private static BUS_MonHoc bUS_MonHoc = new BUS_MonHoc();

        public TrangChu()
        {
            InitializeComponent();
        }


        public void LoadDataSV()
        {
            dataGridView1.DataSource=bUS_SV.getTSV();
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

        private void HeaderTextMH()
        {
            this.dataGridView1.Columns[0].HeaderText = "Mã";
            this.dataGridView1.Columns[1].HeaderText = "Tên";
            this.dataGridView1.Columns[2].HeaderText = "Số Tín Chỉ";
            this.dataGridView1.Columns[3].HeaderText = "Bắt Đầu";
            this.dataGridView1.Columns[4].HeaderText = "Kết Thúc";
            this.dataGridView1.Columns[5].HeaderText = "Buổi";
            this.dataGridView1.Columns[6].HeaderText = "Địa Điểm";
            this.dataGridView1.Columns[7].HeaderText = "Phòng";
            this.dataGridView1.Columns[8].HeaderText = "Mã Giảng Viên";
        }

        private void SizeTextMH()
        {
            this.dataGridView1.Columns[0].Width = 100;
            this.dataGridView1.Columns[1].Width = 230;
            this.dataGridView1.Columns[2].Width = 140;
            this.dataGridView1.Columns[3].Width = 140;
            this.dataGridView1.Columns[4].Width = 140;
            this.dataGridView1.Columns[5].Width = 100;
            this.dataGridView1.Columns[6].Width = 200;
            this.dataGridView1.Columns[7].Width = 100;
            this.dataGridView1.Columns[8].Width = 150;
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            label4.Text = ms;
            label6.Text = ten;

            if (cbb == "Sinh Viên")
            {
                dataGridView1.DataSource = bUS_Diem.getTDiemByMSSV(ms);
                HeaderTextDiem();
                SizeTextDiem();

                smiQLDiem.Visible = false;
                smiQLGV.Visible = false;
                smiQLLop.Visible = false;
                smiQLSV.Visible = false;
            }
            else
            {
                if (cbb == "Giảng Viên")
                {
                    dataGridView1.DataSource = bUS_MonHoc.getTMHByMGV(ms);
                    HeaderTextMH();
                    SizeTextMH();

                    smiQLGV.Visible = false;
                    smiQLLop.Visible = false;
                    smiQLSV.Visible = false;
                    smiThongKe.Visible = false;
                }
                else
                {
                    LoadDataSV();
                    HeaderTextSV();
                    SizeTextSV();
                }
            }
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diem qLD = new Diem();
            qLD.ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ms = "";
            Login login = new Login();
            login.ShowDialog();   
            this.Close();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinhVien qlSV = new SinhVien();
            qlSV.ShowDialog();
            this.Close();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lop qLL = new Lop();
            qLL.ShowDialog();
            this.Close();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thống_kê thong_Ke = new Thống_kê();
            thong_Ke.ShowDialog();
            this.Close();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" && cbb == "Sinh Viên")
            {
                txtSearch.Text = "Nhập mã môn học";
            }
            if (txtSearch.Text == "" && cbb == "Giảng Viên")
            {
                txtSearch.Text = "Nhập mã môn học";
            }
            if(txtSearch.Text == "" && cbb == "Quản trị")
            {
                txtSearch.Text = "Nhập mã sinh viên";
            }    
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void smiQLGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giảng_viên giang_Vien = new Giảng_viên();
            giang_Vien.ShowDialog();
            this.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "" && cbb == "Sinh Viên")
            {
                dataGridView1.DataSource = bUS_Diem.getTDiemByIdMH(txtSearch.Text);
                HeaderTextDiem();
                SizeTextDiem();
            }
            if (txtSearch.Text != "" && cbb == "Giảng Viên")
            {
                dataGridView1.DataSource = bUS_MonHoc.getTMHById(txtSearch.Text);
                HeaderTextMH();
                SizeTextMH();
            }
            if (txtSearch.Text != "" && cbb == "Quản trị")
            {
                dataGridView1.DataSource = bUS_SV.getTSVByID(txtSearch.Text);
                HeaderTextSV();
                SizeTextSV();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
