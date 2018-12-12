using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mntQuanLy.Visible = false;
            mntDSDangKy.Visible = false;
            mntThongKe.Visible = false;
            mntDangXuat.Visible = false;
            mntThongTin.Visible = false;
            this.IsMdiContainer = true;
            this.Hide();
            txtTimKiem.Visible = btnTimKiem.Visible = true;
            txtMK.Visible = txtTK.Visible = btnDangNhap.Visible = btnLui.Visible = false;
            this.CenterToScreen();
        }


        private bool CheckExisForm(string name)
        {
            pictureBox1.Visible = false;
            bool check = false;
            foreach (Form fm in this.MdiChildren)
            {
                if (fm.Name == name)
                {
                    check = true;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form fm in this.MdiChildren)
            {
                if (fm.Name == name)
                {
                    fm.Activate();
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void mntSinhVien_Click(object sender, EventArgs e)
        {
            if (!CheckExisForm("QLSinhVien"))
            {
                QLSinhVien dk = new QLSinhVien();
                dk.MdiParent = this;
                dk.Show();
                dk.Dock = DockStyle.Fill;
            }
            else
            {
                ActiveChildForm("QLSinhVien");
            }
        }

        private void mntMonHoc_Click(object sender, EventArgs e)
        {
            if (!CheckExisForm("QLMonHoc"))
            {
                QLMonHoc dk = new QLMonHoc();
                dk.MdiParent = this;
                dk.Show();
                dk.Dock = DockStyle.Fill;
            }
            else
            {
                ActiveChildForm("QLMonHoc");
            }
        }

        private void mntLopHoc_Click(object sender, EventArgs e)
        {
            if (!CheckExisForm("QLLopHoc"))
            {
                QLLopHoc dk = new QLLopHoc();
                dk.MdiParent = this;
                dk.Show();
                dk.Dock = DockStyle.Fill;
            }
            else
            {
                ActiveChildForm("QLLopHoc");
            }
        }

        private void mntDiem_Click(object sender, EventArgs e)
        {
            if (!CheckExisForm("QLDiem"))
            {
                QLDiem dk = new QLDiem();
                delPassData delpass = new delPassData(dk.LayMaGV);
                delpass(this.txtTK);
                dk.MdiParent = this;
                dk.Show();
                dk.Dock = DockStyle.Fill;
            }
            else
            {
                ActiveChildForm("QLDiem");
            }
        }

        private void mntDaoTao_Click(object sender, EventArgs e)
        {
            if (!CheckExisForm("QLPhongDaoTao"))
            {
                QLPhongDaoTao dk = new QLPhongDaoTao();
                dk.MdiParent = this;
                dk.Show();
                dk.Dock = DockStyle.Fill;
            }
            else
            {
                ActiveChildForm("QLPhongDaoTao");
            }
        }

        private void mntDSDangKy_Click(object sender, EventArgs e)
        {
            if (!CheckExisForm("QLDangKy"))
            {
                QLDangKy dk = new QLDangKy();
                dk.MdiParent = this;
                dk.Show();
                dk.Dock = DockStyle.Fill;
            }
            else
            {
                ActiveChildForm("QLDangKy");
            }
        }

        private void mntGiangVien_Click(object sender, EventArgs e)
        {
            if (!CheckExisForm("QLGiangVien"))
            {
                QLGiangVien dk = new QLGiangVien();
                dk.MdiParent = this;
                dk.Show();
                dk.Dock = DockStyle.Fill;
            }
            else
            {
                ActiveChildForm("QLGiangVien");
            }
        }

        private void mntQLTaiKhoan_Click(object sender, EventArgs e)
        {
            if (!CheckExisForm("QLTaiKhoan"))
            {
                QLTaiKhoan dk = new QLTaiKhoan();
                dk.MdiParent = this;
                dk.Show();
                dk.Dock = DockStyle.Fill;
            }
            else
            {
                ActiveChildForm("QLTaiKhoan");
            }
        }

        private int chuyen(char c)
        {
            return (int)c - 0;
        }

        private bool KiemTraChuoi(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (chuyen(text[i]) > 57 || chuyen(text[i]) < 48)
                    return false;
            }
            return true;
        }

        public delegate void delPassData(TextBox text);
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //lblThongBao.Visible = true;
            if (KiemTraChuoi(txtTimKiem.Text))
            {
                if (SinhVienBUS.KiemTraSinhVienTonTai(txtTimKiem.Text))
                {
                    QLTTCTSinhVien frm = new QLTTCTSinhVien();
                    delPassData del = new delPassData(frm.LayMaSV);
                    del(this.txtTimKiem);
                    frm.Show();
                    txtTimKiem.Text = "";

                }
                else
                {
                    txtTimKiem.Text = "Sinh Viên Không Tồn Tại!!!";
                }
            }
            else
            {
                txtTimKiem.Text = "Tìm Kiếm Theo Mã Sinh Viên";
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (TaiKhoanBUS.KiemTraDangNhap(txtTK.Text, txtMK.Text))
            {
                if (TaiKhoanBUS.CheckQuyenHan(txtTK.Text) == 1)
                {
                    mntQuanLy.Visible = true;
                    mntDSDangKy.Visible = true;
                    mntThongKe.Visible = true;   
                    mntDiem.Visible = true;
                    mntGiangVien.Visible = true;
                    mntMonHoc.Visible = true;
                    mntLopHoc.Visible = true;
                    mntQLTaiKhoan.Visible = true;
                    mntSinhVien.Visible = true;
                    mntThongTin.Text = txtTK.Text;
                }
                else if (TaiKhoanBUS.CheckQuyenHan(txtTK.Text) == 2)
                {
                    mntDSDangKy.Visible = true;
                    mntThongTin.Text = "Thu Ngân " + txtTK.Text;
                }
                else if (TaiKhoanBUS.CheckQuyenHan(txtTK.Text) == 3)
                {
                    mntQuanLy.Visible = true;
                    mntDiem.Visible = true;
                    mntGiangVien.Visible = false;
                    mntMonHoc.Visible = false;
                    mntLopHoc.Visible = false;
                    mntQLTaiKhoan.Visible = false;
                    mntSinhVien.Visible = false;
                    mntThongTin.Text = "Giáo Viên " + txtTK.Text;
                }
                mntTaiKhoan.Visible = true;
                mntThongTin.Visible = true;
                mntDangXuat.Visible = true;
                mntDangNhap.Visible = false;
                txtTK.Visible = txtMK.Visible = btnDangNhap.Visible = btnLui.Visible = false;
            }
            else
            {
                txtTK.Text = "Đăng Nhập Thất Bại!!!";
            }
        }

        private void mntDangNhap_Click(object sender, EventArgs e)
        {
            txtTimKiem.Visible = btnTimKiem.Visible = false;
            txtMK.Visible = txtTK.Visible = btnDangNhap.Visible = btnLui.Visible = true;
            txtMK.Text = "123456";
            txtTK.Text = "Admin";
        }

        private void mntDangXuat_Click(object sender, EventArgs e)
        {
            mntQuanLy.Visible = false;
            mntDSDangKy.Visible = false;
            mntThongKe.Visible = false; 
            mntDangXuat.Visible = false;
            mntThongTin.Visible = false;
            mntDangNhap.Visible = btnLui.Visible = true;
            txtTimKiem.Visible = btnTimKiem.Visible = true;
            txtMK.Visible = txtTK.Visible = btnDangNhap.Visible = btnLui.Visible =  false;
            pictureBox1.Visible = true;
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            txtTimKiem.Visible = btnTimKiem.Visible = true;
            txtMK.Visible = txtTK.Visible = btnDangNhap.Visible = btnLui.Visible = false;
        }

       
    }
}
