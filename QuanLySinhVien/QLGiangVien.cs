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
    public partial class QLGiangVien : Form
    {
        public QLGiangVien()
        {
            InitializeComponent();
            btnSua.Enabled = false;
            btnXoa.Visible = false;
        }

        private static QLGiangVien _Instance = null;

        public static QLGiangVien Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLGiangVien();
                return _Instance;
            }
        }

        private void QLGiangVien_Load(object sender, EventArgs e)
        {
            cboHocVi.SelectedIndex = 0;

            List<NganhDTO> listNganh = NganhBUS.LayDanhSachNganh();
            NganhDTO all = new NganhDTO();
            all.MaNganh = 0;
            all.TenNganh = "Tất Cả";
            all.TrangThai = false;
            listNganh.Insert(0, all);
            //
            cboNganh.DisplayMember = "TenNganh";
            cboNganh.ValueMember = "MaNganh";
            cboNganh.DataSource = listNganh;
            cboNganh.SelectedValue = 0;

            lsvGiangVien.Items.Clear();
            List<GiangVienDTO> listGV = GiangVienBUS.LayDanhSachGiangVien();
            lsvGiangVien.Columns.Add("ID", 50, HorizontalAlignment.Center);
            lsvGiangVien.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvGiangVien.Columns.Add("HỌ", 200, HorizontalAlignment.Center);
            lsvGiangVien.Columns.Add("TÊN", 150, HorizontalAlignment.Center);
            lsvGiangVien.Columns.Add("GIỚI TÍNH", 100, HorizontalAlignment.Center);
            lsvGiangVien.Columns.Add("NƠI SINH", 150, HorizontalAlignment.Center);
            lsvGiangVien.Columns.Add("NGÀY SINH", 200, HorizontalAlignment.Center);
            lsvGiangVien.Columns.Add("HỌC VỊ", 200, HorizontalAlignment.Center);
            lsvGiangVien.Columns.Add("NGÀNH", 200, HorizontalAlignment.Center);
            lsvGiangVien.Columns.Add("EMAIL ", 200, HorizontalAlignment.Center);
            lsvGiangVien.Columns.Add("TÌNH TRẠNG", 200, HorizontalAlignment.Center);
            lsvGiangVien.Columns.Add("SĐT", 200, HorizontalAlignment.Center);

            lsvGiangVien.View = View.Details;
            lsvGiangVien.GridLines = true;
            lsvGiangVien.FullRowSelect = true;


            LoadGiangVien(listGV);

        }

        private void LoadGiangVien(List<GiangVienDTO> listGV)
        {
            lsvGiangVien.Items.Clear();
            lsvGiangVien.Dock = DockStyle.Fill;
            for (int i = 0; i < listGV.Count(); i++)
            {
                GiangVienDTO sv = listGV[i];
                ListViewItem liv = new ListViewItem();
                liv.Text = sv.MaGV.ToString();
                liv.SubItems.Add(sv.Ho);
                liv.SubItems.Add(sv.Ten);
                if (sv.GioiTinh == false)
                    liv.SubItems.Add("Nam");
                else
                    liv.SubItems.Add("Nữ");
                liv.SubItems.Add(sv.NoiSinh);
                liv.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                liv.SubItems.Add(sv.HocVi.ToString());
                liv.SubItems.Add(sv.Nganh.ToString());
                liv.SubItems.Add(sv.Email.ToString());
                if(sv.TinhTrang == false)
                    liv.SubItems.Add("Hết Giảng Dạy");
                else
                    liv.SubItems.Add("Đang Giảng Dạy");
                liv.SubItems.Add(sv.SDT.ToString());
                liv.Tag = sv;
                lsvGiangVien.Items.Add(liv);
            }
        }

        private void lsvGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            if (lsvGiangVien.SelectedItems.Count > 0)
            {
                ListViewItem liv = lsvGiangVien.SelectedItems[0];
                GiangVienDTO sv = (GiangVienDTO)liv.Tag;
                txtMaSV.Text = sv.MaGV.ToString();
                txtHo.Text = sv.Ho;
                txtTen.Text = sv.Ten;
                if (sv.GioiTinh == false)
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
                txtNoiSinh.Text = sv.NoiSinh;
                dtpkNgaySinh.Text = sv.NgaySinh.ToString();
                //cboNganh.SelectedValue = sv.MaNganh;
                // cboHe.SelectedValue = sv.MaHe;
                // cboTinhTrang.SelectedValue = sv.TinhTrang;
                cboNganh.Text = sv.Nganh;
                cboHocVi.Text = sv.HocVi;
               
                if (sv.TinhTrang == true)
                    chkTinhTrang.Checked = true;
                else
                    chkTinhTrang.Checked = false;
                txtEmail.Text = sv.Email.ToString();
                txtSDT.Text = sv.SDT;
            }
            else
            {
                cboNganh.SelectedIndex = -1;
                cboHocVi.SelectedIndex = -1;
                txtSDT.Text = txtEmail.Text = txtHo.Text = txtNoiSinh.Text = txtTen.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHo.Text == "" || txtTen.Text == "" || cboHocVi.Text == "Tất cả" || cboNganh.Text == "Tất Cả")
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            else
            {
                GiangVienDTO sv = new GiangVienDTO();
                sv.Ho = txtHo.Text;
                sv.Ten = txtTen.Text;
                if (radNam.Checked == false)
                    sv.GioiTinh = true;
                else
                    sv.GioiTinh = false;
                sv.NoiSinh = txtNoiSinh.Text;
                sv.NgaySinh = Convert.ToDateTime(dtpkNgaySinh.Text);
                sv.Nganh = cboNganh.SelectedValue.ToString();
                sv.HocVi = cboHocVi.Text;
                sv.TinhTrang = Convert.ToBoolean(chkTinhTrang.Checked);
                sv.Email = txtEmail.Text;
                sv.SDT = txtSDT.Text;
                if (GiangVienBUS.ThemGiangVien(sv))
                {
                    MessageBox.Show("Thêm thành công");
                    List<GiangVienDTO> lstSinhVien = GiangVienBUS.LayDanhSachGiangVien();
                    LoadGiangVien(lstSinhVien);
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    sv = null;
                }
            }
        }

        private void ClearTextBox()
        {
            cboNganh.SelectedIndex = 0;
            cboHocVi.SelectedIndex = 0;
            txtSDT.Text = txtEmail.Text = txtHo.Text = txtNoiSinh.Text = txtTen.Text = "";
            chkTinhTrang.Checked = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            radNam.Checked = radNu.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHo.Text == "" || txtTen.Text == "" || cboHocVi.Text == "Tất cả" || cboNganh.Text == "Tất Cả")
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            else
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                GiangVienDTO sv = new GiangVienDTO();
                sv.MaGV = Convert.ToInt32(txtMaSV.Text);
                sv.Ho = txtHo.Text;
                sv.Ten = txtTen.Text;
                if (radNam.Checked == false)
                    sv.GioiTinh = true;
                else
                    sv.GioiTinh = false;
                sv.NoiSinh = txtNoiSinh.Text;
                sv.NgaySinh = Convert.ToDateTime(dtpkNgaySinh.Text);
                sv.Nganh = cboNganh.SelectedValue.ToString();
                sv.HocVi = cboHocVi.Text;
                sv.TinhTrang = Convert.ToBoolean(chkTinhTrang.Checked);
                sv.Email = txtEmail.Text;
                sv.SDT = txtSDT.Text;

                tk.TenTaiKhoan = txtMaSV.Text;
                tk.MatKhau = "123456";
                tk.PhanQuyen = 3;
                tk.TrangThai = true;

                if (TaiKhoanBUS.KiemTraTrungTenTaiKhoan(tk.TenTaiKhoan))
                {
                    if (TaiKhoanBUS.KiemTraTaiKhoanTonTai(tk))
                    {
                        MessageBox.Show("Đã Thông tài Khoản Giáo Viên Mới!!!");
                    }
                }
                if (GiangVienBUS.UpdateGiangVien(sv))
                {
                    MessageBox.Show("Cập Nhật thành công");
                    List<GiangVienDTO> lstSinhVien = GiangVienBUS.LayDanhSachGiangVien();
                    LoadGiangVien(lstSinhVien);
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Cập Nhật thất bại");
                    sv = null;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
    }
}
