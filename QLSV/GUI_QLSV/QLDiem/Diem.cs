using BUS_QLSV;
using DTO_QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLSV
{
    public partial class Diem : Form
    {
        private static BUS_SV bUS_SV = new BUS_SV();
        private static BUS_Diem bUS_Diem = new BUS_Diem();
        private static BUS_MonHoc bUS_MonHoc = new BUS_MonHoc();

        public Diem()
        {
            InitializeComponent();
        }

        public void LoadDiem()
        {
            dataGridView1.DataSource = bUS_Diem.getTDiem();
        }

        private void HeaderText()
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

        private void SizeText()
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

        private void Diem_Load(object sender, EventArgs e)
        {

            LoadDiem();
            HeaderText();
            SizeText();

            lbid.Visible = false;
            labid.Visible = false;

            string[] pt = { "30", "40", "50", "60", "70"};
            foreach (string p in pt)
            {
                cbbCK.Items.Add(p);
                cbbGK.Items.Add(p);
            }

            if (TrangChu.cbb == "Giảng Viên")
            {
                dataGridView1.DataSource = bUS_Diem.getTDiemByIdGV(TrangChu.ms);
                smiQLGV.Visible = false;
                smiQLLop.Visible = false;
                smiQlSV.Visible = false;
                smiThongKe.Visible = false;
                DataSet data = bUS_MonHoc.getMHByMGV(TrangChu.ms);
                cbbMH.DataSource = data.Tables[0];
                cbbMH.DisplayMember = "id";
            }
            else
            {
                DataSet data = bUS_MonHoc.getMH();
                cbbMH.DataSource = data.Tables[0];
                cbbMH.DisplayMember = "id";
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();
        }

        public float TinhHe10()
        {
            double gk = Convert.ToDouble(txtGK.Text);
            double ck = Convert.ToDouble(txtCK.Text);
            double gkh = Convert.ToDouble(cbbGK.Text);
            double ckh = Convert.ToDouble(cbbGK.Text);
            double he10 = gk * (gkh * 0.01) + ck * (ckh * 0.01);
            float he = (float)he10;
            return he;
        }

        public float TinhHe4(float diem)
        {
            if(diem <= 10 && diem >= 8.5)
            {
                return 4;
            }
            if(diem <= 8.4 && diem >= 7)
            {
                return 3;
            }
            if(diem <= 6.9 && diem >= 5.5)
            {
                return 2;
            }
            if(diem <= 5.4 && diem >= 4)
            {
                return 1;
            }
            else 
            { 
                return 0; 
            }        
        }

        public string Loai( float diem)
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

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text != "" && cbbGK.Text != "" && cbbCK.Text != "" && txtCK.Text != "" 
                && txtGK.Text != "")
            {
                double num;
                if (double.TryParse(txtGK.Text, out num) && double.TryParse(txtCK.Text, out num))
                {
                    float gk = float.Parse(txtGK.Text);
                    float ck = float.Parse(txtCK.Text);

                    if (gk < 11 && gk >= 0 && ck <= 11 && ck >= 0)
                    {
                        double pgk = Convert.ToDouble(cbbGK.Text);
                        double pck = Convert.ToDouble(cbbCK.Text);

                        float he10 = TinhHe10();
                        float he4 = TinhHe4(he10);
                        double pt = pgk + pck;

                        if (pt == 100)
                        {
                            DTO_Diem dTO_Diem = new DTO_Diem(txtMSSV.Text, cbbMH.Text, gk, ck, he10, he4, Loai(he10));

                            if (bUS_Diem.ThemDiem(dTO_Diem))
                            {
                                MessageBox.Show("THÊM THÀNH CÔNG");
                                txtCK.Clear();
                                txtGK.Clear();
                                txtMSSV.Clear();
                                LoadDiem();
                            }
                            else { MessageBox.Show("THÊM KHÔNG THÀNH CÔNG"); }
                        }
                        else { MessageBox.Show("PHẦN TRĂM NHẬP SAI"); }
                    }
                    else { MessageBox.Show("Nhập điểm sai"); }
                }
                else { MessageBox.Show("Nhập điểm sai định dạng"); }
            }
             else { MessageBox.Show("THÔNG TIN SAI HOẶC NHẬP THIẾU THÔNG TIN"); }
}

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (txtMSSV.Text != "" && txtGK.Text != "" && txtCK.Text != "" && cbbGK.Text != ""
                    && cbbCK.Text != "")
                {
                    double num;
                    if (double.TryParse(txtGK.Text, out num) && double.TryParse(txtCK.Text, out num))
                    {
                        float gk = float.Parse(txtGK.Text);
                        float ck = float.Parse(txtCK.Text);

                        if (gk < 11 && gk >= 0 && ck <= 11 && ck >= 0)
                        {
                            double pgk = Convert.ToDouble(cbbGK.Text);
                            double pck = Convert.ToDouble(cbbCK.Text);

                            float he10 = TinhHe10();
                            float he4 = TinhHe4(he10);
                            double pt = pgk + pck;

                            if (pt == 100)
                            {
                                int id = Convert.ToInt32(labid.Text);
                                DTO_Diem dTO_Diem = new DTO_Diem(id, txtMSSV.Text, cbbMH.Text, gk, ck, he10, he4, Loai(he10));

                                if (bUS_Diem.SuaDiem(dTO_Diem))
                                {
                                    MessageBox.Show("SỬA THÀNH CÔNG");
                                    txtCK.Clear();
                                    txtGK.Clear();
                                    txtMSSV.Clear();
                                    LoadDiem();
                                }
                                else { MessageBox.Show("SỬA KHÔNG THÀNH CÔNG"); }
                            }
                            else { MessageBox.Show("PHẦN TRĂM NHẬP SAI"); }
                        }
                        else { MessageBox.Show("Nhập điểm sai"); }
                    }
                    else { MessageBox.Show("Nhập điểm sai định dạng"); }
                }
                else { MessageBox.Show("HÃY CHỌN PHIẾU ĐIỂM MUỐN SỬA"); }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int ID = Convert.ToInt16(labid.Text);

                if (bUS_Diem.XoaDiem(ID))
                {
                    MessageBox.Show("XÓA THÀNH CÔNG");
                    LoadDiem();
                }
                else { MessageBox.Show("XÓA KHÔNG THÀNH CÔNG"); }
            }
            else { MessageBox.Show("HÃY CHỌN PHIẾU ĐIỂM MUỐN XÓA"); }
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

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbid.Visible = false;
            labid.Visible = false;
            int index;
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                labid.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtMSSV.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                cbbMH.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                cbbMH.DisplayMember = "id";
                txtGK.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                txtCK.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            }
        }

        private void smiThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thống_kê thong_Ke = new Thống_kê();
            thong_Ke.ShowDialog();
            this.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_SV.getTSVByID(txtSearch.Text);
            HeaderTextSV();
            SizeTextSV();
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

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm mã sinh sinh";    
            }    
            
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        
    }
}
