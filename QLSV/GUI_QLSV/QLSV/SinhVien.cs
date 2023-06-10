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
    public partial class SinhVien : Form
    {
        private static BUS_SV bUS_SV = new BUS_SV();
        private static BUS_GV bUS_GV = new BUS_GV();
        private static BUS_Lop bUS_Lop = new BUS_Lop();
        private static BUS_MonHoc bUS_MonHoc = new BUS_MonHoc();

        public SinhVien()
        {
            InitializeComponent();
        }

        public void LoadDataSV()
        {
            dataGridView1.DataSource = bUS_SV.getTSV();
        }

        private void HeaderText()
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

        private void SizeText()
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

        private void SinhVien_Load(object sender, EventArgs e)
        {

            LoadDataSV();
            HeaderText();
            SizeText();

            DataSet data = bUS_Lop.getLop();
            cbbLop.DataSource = data.Tables[0];
            cbbLop.DisplayMember = "id";

            string[] trthai = { "Đang Học", "Bảo Lưu", "Tốp Nghiệp", "Nghĩ Học", "Cấm Học" };
            foreach (string t in trthai)
            {
                cbbTrangThai.Items.Add(t);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && mtxtCCCD.Text != "" && txtEmail.Text != "" && mtxtMSSV.Text != "" &&
                txtQue.Text != "" && mtxtSDT.Text != "" && mtxtNgaySinh.Text != "" && cbbTrangThai.Text != ""
                && cbbLop.Text != "")
            {
                    int lop = Convert.ToInt32(cbbLop.Text);
                    DTO_SV dTO_SV = new DTO_SV(mtxtMSSV.Text, txtHoTen.Text, mtxtCCCD.Text, mtxtNgaySinh.Text,
                        txtQue.Text, mtxtSDT.Text, txtEmail.Text, cbbTrangThai.Text, rabtNam.Checked ? "Nam" : "Nữ", lop);

                    if (bUS_SV.ThemSV(dTO_SV))
                    {
                        MessageBox.Show("THÊM THÀNH CÔNG");
                        txtEmail.Clear();
                        txtHoTen.Clear();
                        txtQue.Clear();
                        mtxtCCCD.Clear();
                        mtxtMSSV.Clear();
                        mtxtNgaySinh.Clear();
                        mtxtSDT.Clear();
                        LoadDataSV();
                    }
                    else { MessageBox.Show("THÊM KHÔNG THÀNH CÔNG"); }
            }
            else { MessageBox.Show("XIN HÃY NHẬP ĐẦY ĐỦ THÔNG TIN"); }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (txtHoTen.Text != "" && mtxtCCCD.Text != "" && txtEmail.Text != "" && mtxtMSSV.Text != "" &&
                txtQue.Text != "" && mtxtSDT.Text != "" && mtxtNgaySinh.Text != "" && cbbTrangThai.Text != ""
                && cbbLop.Text != "")
                {
                    int lop = Convert.ToInt32(cbbLop.Text);

                    DTO_SV dTO_SV = new DTO_SV(mtxtMSSV.Text, txtHoTen.Text, mtxtCCCD.Text, mtxtNgaySinh.Text,
                        txtQue.Text,mtxtSDT.Text, txtEmail.Text, cbbTrangThai.Text, rabtNam.Checked ? "Nam" : "Nữ", lop);
                    if (bUS_SV.SuaSV(dTO_SV))
                    {
                        MessageBox.Show("SỬA THÀNH CÔNG");
                        txtEmail.Clear();
                        txtHoTen.Clear();
                        txtQue.Clear();
                        mtxtCCCD.Clear();
                        mtxtMSSV.Clear();
                        mtxtNgaySinh.Clear();
                        mtxtSDT.Clear();
                        LoadDataSV();
                    }
                    else { MessageBox.Show("SỬA KHÔNG THÀNH CÔNG"); }
                }
                else { MessageBox.Show("THÔNG TIN SAI HOẶC NHẬP THIẾU THÔNG TIN"); }
            }
            else { MessageBox.Show("HÃY CHỌN PHIẾU ĐIỂM MUỐN SỬA"); }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {

                if (bUS_SV.XoaSV(mtxtMSSV.Text))
                {
                    MessageBox.Show("XÓA THÀNH CÔNG");
                    LoadDataSV();
                }
                else { MessageBox.Show("XÓA KHÔNG THÀNH CÔNG"); }
            }
            else { MessageBox.Show("HÃY CHỌN PHIẾU ĐIỂM MUỐN XÓA"); }
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diem diem = new Diem();
            diem.ShowDialog();
            this.Close();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lop lop = new Lop();
            lop.ShowDialog();
            this.Close();
        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giảng_viên giang_Vien = new Giảng_viên();
            giang_Vien.ShowDialog();
            this.Close();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thống_kê thongKe = new Thống_kê();
            thongKe.ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            if(e.RowIndex >= 0) 
            {
                index = e.RowIndex;
                mtxtMSSV.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtHoTen.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                mtxtNgaySinh.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                mtxtCCCD.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

                if (dataGridView1.Rows[index].Cells[4].Value.ToString() == "Nam")
                {
                    rabtNam.Checked = true;
                }
                else { rabtNu.Checked = true; }

                cbbLop.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();
                cbbTrangThai.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();
                txtQue.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
                mtxtSDT.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_SV.getTSVByID(txtSearch.Text);
            HeaderTextMH();
            SizeTextMH();
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
    }
}
