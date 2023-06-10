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
    public partial class Lop : Form
    {
        private static BUS_Khoa bUS_Khoa = new BUS_Khoa();
        private static BUS_Lop bUS_Lop = new BUS_Lop();

        public Lop()
        {
            InitializeComponent();
        }

        public void LoadDataLop()
        {
            dataGridView1.DataSource = bUS_Lop.getTLop();
        }

        private void HeaderText()
        {
            this.dataGridView1.Columns[0].HeaderText = "Mã";
            this.dataGridView1.Columns[1].HeaderText = "Tên";
            this.dataGridView1.Columns[2].HeaderText = "Khóa Học";
            this.dataGridView1.Columns[3].HeaderText = "Mã Khoa";
        }

        private void SizeText()
        {
            this.dataGridView1.Columns[0].Width = 100;
            this.dataGridView1.Columns[1].Width = 150;
            this.dataGridView1.Columns[2].Width = 200;
            this.dataGridView1.Columns[3].Width = 150;
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            lbID.Visible = false;
            labId.Visible = false;

            LoadDataLop();
            HeaderText();
            SizeText();

            cbbKhoa.DataSource = bUS_Khoa.getTKhoa();
            cbbKhoa.DisplayMember = "id";
        }

        private void btThem_Click(object sender, EventArgs e)
        { 
            if (txtTen.Text != "" && txtKhoaHoc.Text != "")
            {
                DTO_Lop dTO_Lop = new DTO_Lop(txtTen.Text, txtKhoaHoc.Text, cbbKhoa.Text);

                if (bUS_Lop.ThemLop(dTO_Lop))
                {
                    MessageBox.Show("THÊM THÀNH CÔNG");
                    txtKhoaHoc.Clear();
                    txtTen.Clear();
                    LoadDataLop();
                }
                else
                {
                    MessageBox.Show("THÊM KHÔNG THÀNH CÔNG");
                }
            }
            else
            {
                MessageBox.Show("XIN HÃY NHẬP ĐẦY ĐỦ THÔNG TIN");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (txtTen.Text != "" && txtKhoaHoc.Text != "")
                {
                    int ID = Convert.ToInt16(labId.Text);
                    DTO_Lop dTO_Lop = new DTO_Lop(ID, txtTen.Text, txtKhoaHoc.Text, cbbKhoa.Text);
                    if (bUS_Lop.SuaLop(dTO_Lop))
                    {
                        MessageBox.Show("SỬA THÀNH CÔNG");
                        txtKhoaHoc.Clear();
                        txtTen.Clear();
                        LoadDataLop();
                    }
                    else
                    {
                        MessageBox.Show("SỬA KHÔNG THÀNH CÔNG");
                    }
                }
                else
                {
                    MessageBox.Show("THÔNG TIN BỊ SAI HOẶC NHẬP THIẾU THÔNG TIN");
                }
            }
            else
            {
                MessageBox.Show("HÃY CHỌN LỚP MUỐN SỬA");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int ID = Convert.ToInt16(labId.Text);
      
                if (bUS_Lop.XoaLop(ID))
                {
                    MessageBox.Show("XÓA THÀNH CÔNG");
                    LoadDataLop();
                }
                else
                {
                    MessageBox.Show("XÓA KHÔNG THÀNH CÔNG");
                }
            }
            else
            {
                MessageBox.Show("HÃY CHỌN LỚP MUỐN XÓA");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();

        }

        private void HeaderTextKhoa()
        {
            this.dataGridView1.Columns[0].HeaderText = "Mã";
            this.dataGridView1.Columns[1].HeaderText = "Tên";
            this.dataGridView1.Columns[2].HeaderText = "Email";
            this.dataGridView1.Columns[3].HeaderText = "SĐT";
        }

        private void SizeTextKhoa()
        {
            this.dataGridView1.Columns[0].Width = 100;
            this.dataGridView1.Columns[1].Width = 300;
            this.dataGridView1.Columns[2].Width = 300;
            this.dataGridView1.Columns[3].Width = 150;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_Khoa.getTKhoaById(txtSearch.Text);
            HeaderTextKhoa();
            SizeTextKhoa();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbID.Visible = true;
            labId.Visible = true;

            int index;
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                labId.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtTen.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txtKhoaHoc.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                cbbKhoa.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                cbbKhoa.DisplayMember = "id";
            }  
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();
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
            Giảng_viên giảng_Viên = new Giảng_viên();
            giảng_Viên.ShowDialog();
            this.Close();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thống_kê thống_Kê = new Thống_kê();
            thống_Kê.ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        
    }
}
