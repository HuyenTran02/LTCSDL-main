using BUS_QLSV;
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
    public partial class Login : Form
    {
        int soLan = 3;
        bool co = true;

        BUS_SV bUS_SV = new BUS_SV();
        BUS_GV bUS_GV = new BUS_GV();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string[] loai = { "Sinh Viên", "Giảng Viên"};
            foreach(string l in loai)
            {
                cbbLoai.Items.Add(l);
            }    
        }

        private void btLogin_Click_1(object sender, EventArgs e)
        {
            if (txtMS.Text != "" && txtPass.Text != "" && cbbLoai.Text != "")
            {
                switch(cbbLoai.Text)
                {
                    case "Sinh Viên":
                        if (bUS_SV.getTSVByID(txtMS.Text).Rows.Count == 1)
                        {
                            if (bUS_SV.getTSVByID(txtMS.Text).Rows[0][2].ToString() == txtPass.Text)
                            {
                                this.Hide();
                                TrangChu.ms = txtMS.Text;
                                TrangChu.ten = bUS_SV.getTSVByID(txtMS.Text).Rows[0][1].ToString();
                                TrangChu.cbb = cbbLoai.Text;
                                TrangChu trangChu = new TrangChu();
                                trangChu.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("MẬT KHẨU SAI!!!");
                                txtPass.Clear();
                                soLan--;
                                co = false;
                                if (soLan == 0)
                                {
                                    Application.Exit();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("MÃ SỐ NHẬP SAI!!!");
                            txtPass.Clear();
                            txtMS.Clear();
                        }
                        break;

                    case "Giảng Viên":
                        if (bUS_GV.getTGVById(txtMS.Text).Rows.Count == 1)
                        {
                            if (bUS_GV.getTGVById(txtMS.Text).Rows[0][3].ToString() == txtPass.Text)
                            {
                                    this.Hide();
                                    TrangChu.ten = bUS_GV.getTGVById(txtMS.Text).Rows[0][1].ToString();
                                    TrangChu.cbb = cbbLoai.Text;
                                    TrangChu.ms = txtMS.Text;
                                    TrangChu trangChu = new TrangChu();
                                    trangChu.ShowDialog();
                                    this.Close();  
                            }
                            else
                            {
                                MessageBox.Show("MẬT KHẨU SAI!!!");
                                txtPass.Clear();
                                soLan--;
                                co = false;
                                if (soLan == 0)
                                {
                                    Application.Exit();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("MÃ SỐ NHẬP SAI!!!");
                            txtPass.Clear();
                            txtMS.Clear();
                        }
                        break;
                }   
            }
            else if(txtMS.Text == "123456" && txtPass.Text == "admin")
                {
                this.Hide();
                TrangChu.ten = "Admin";
                TrangChu.cbb = "Quản trị";
                TrangChu.ms = txtMS.Text;
                TrangChu trangChu = new TrangChu();
                trangChu.ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("NHẬP THIẾU THÔNG TIN!!!"); }
        }


        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked) { txtPass.UseSystemPasswordChar = false; }
            else { txtPass.UseSystemPasswordChar = true; }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
