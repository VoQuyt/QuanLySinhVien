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
    public partial class QLTTCTSinhVien : Form
    {
        public QLTTCTSinhVien()
        {
            InitializeComponent();
           // lblMonHoc.Visible = false;
            cboMon.Visible = false;
            btnXacNhan.Visible = false;
            this.CenterToScreen();
        }

        private static QLTTCTSinhVien _Instance = null;

        public static QLTTCTSinhVien Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLTTCTSinhVien();
                return _Instance;
            }
        }

        public void LayMaSV(TextBox txtTKFrmHome)
        {
            lblMaSV.Text = txtTKFrmHome.Text;
            SinhVienDTO sv = SinhVienBUS.LayThongTinSinhVien(lblMaSV.Text);
            lblTen.Text = sv.Ho + " " +sv.Ten;
            if (sv.GioiTinh == true)
                lblGioiTinh.Text = "Nữ";
            else
                lblGioiTinh.Text = "Nam";
            lblNoiSinh.Text = sv.NoiSinh;
            lblNgaySinh.Text = sv.NgaySinh.ToString("dd/MM/yyyy");
            lblNganh.Text = sv.MaNganh;
            lblHe.Text = sv.MaHe;
        }

        private void btnDKMH_Click(object sender, EventArgs e)
        {
            //lblMonHoc.Visible = true;
            cboMon.Visible = true;
            btnXacNhan.Visible = true;
            List<LopHocDTO> lstLop = LopHocBUS.LayDanhSachLopHocTheoSV(lblMaSV.Text);
            cboMon.DisplayMember = "TenLop";
            cboMon.ValueMember = "MaLop";
            cboMon.DataSource = lstLop;
        }

        public delegate void delPassData(Label lblma, Label lblten);
        private void bntDiem_Click(object sender, EventArgs e)
        {

            //lblMonHoc.Visible = false;
            cboMon.Visible = false;
            btnXacNhan.Visible = false;
            QLDiemCTSinhVien diem = new QLDiemCTSinhVien();
            delPassData del = new delPassData(diem.LayMaSV);
            del(this.lblMaSV, lblTen);
            diem.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cboMon.Text == "" || cboMon.Text == "KHÔNG CÓ LỚP")
                cboMon.Text = "KHÔNG CÓ LỚP";
            else
            {
                DangKyDTO dk = new DangKyDTO();
                dk.MaLop = cboMon.SelectedValue.ToString();
                dk.MaSV = lblMaSV.Text;
                dk.NgayDangKi = DateTime.Now;
                dk.TrangThai = false;
                if (DangKiBUS.KiemTraSinhVienDangKi(dk))
                {
                    List<LopHocDTO> lstLop = LopHocBUS.LayDanhSachLopHocTheoSV(lblMaSV.Text);
                    cboMon.DisplayMember = "TenLop";
                    cboMon.ValueMember = "MaLop";
                    cboMon.DataSource = lstLop;
                    MessageBox.Show("ĐĂNG KÝ THÀNH CÔNG");
                }
                else
                {
                    dk = null;
                    MessageBox.Show("ĐANG CHỜ PHÊ DUYỆT");
                }
            }
        }
    }
}
