using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLySinhVien
{
    public partial class QLSinhVien : Form
    {
        public QLSinhVien()
        {
            InitializeComponent();
            btnSua.Enabled = false;
           
        }

        private static QLSinhVien _Instance = null;

        public static QLSinhVien Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLSinhVien();
                return _Instance;
            }
        }

        private void QLSinhVien_Load(object sender, EventArgs e)
        {
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


            List<HeDaoTaoDTO> listHeDaoTao = HeDaoTaoBUS.LayDanhSachHe();
            HeDaoTaoDTO alL = new HeDaoTaoDTO();
            alL.MaHe = 0;
            alL.TenHe = "Tất Cả";
            alL.TrangThai = false;
            listHeDaoTao.Insert(0, alL);
            //
            cboHe.DisplayMember = "TenHe";
            cboHe.ValueMember = "MaHe";
            cboHe.DataSource = listHeDaoTao;
            cboHe.SelectedValue = 0;

            List<TinhTrangDTO> listTinhTrang = SinhVienBUS.GetListTinhTrang();
            TinhTrangDTO aLL = new TinhTrangDTO();
            aLL.ID = 0;
            aLL.TinhTrang = "Tất Cả";
            listTinhTrang.Insert(0, aLL);
            //
            cboTinhTrang.DisplayMember = "TinhTrang";
            cboTinhTrang.ValueMember = "ID";
            cboTinhTrang.DataSource = listTinhTrang;
            cboTinhTrang.SelectedValue = 0;

            lsvStudent.Items.Clear();
            List<SinhVienDTO> listSV = SinhVienBUS.GetListSinhVien();
            lsvStudent.Columns.Add("ID", 50);
            lsvStudent.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvStudent.Columns.Add("HỌ", 200);
            lsvStudent.Columns.Add("TÊN", 150, HorizontalAlignment.Center);
            lsvStudent.Columns.Add("GIỚI TÍNH", 100);
            lsvStudent.Columns.Add("NƠI SINH", 150);
            lsvStudent.Columns.Add("NGÀY SINH", 200, HorizontalAlignment.Center);
            lsvStudent.Columns.Add("NGÀNH", 200);
            lsvStudent.Columns.Add("HỆ ", 200);
            lsvStudent.Columns.Add("TÌNH TRẠNG", 200);
            lsvStudent.Columns.Add("NIÊN KHÓA", 200, HorizontalAlignment.Center);

            lsvStudent.View = View.Details;
            lsvStudent.GridLines = true;
            lsvStudent.FullRowSelect = true;


            LoadSinhVien(listSV);
        }

        private void LoadSinhVien(List<SinhVienDTO> listSV)
        {
            lsvStudent.Items.Clear();
            lsvStudent.Dock = DockStyle.Fill;
            for (int i = 0; i < listSV.Count(); i++)
            {
                SinhVienDTO sv = listSV[i];
                ListViewItem liv = new ListViewItem();
                liv.Text = sv.MaSV.ToString();
                liv.SubItems.Add(sv.Ho);
                liv.SubItems.Add(sv.Ten);
                if (sv.GioiTinh == false)
                    liv.SubItems.Add("Nam");
                else
                    liv.SubItems.Add("Nữ");
                liv.SubItems.Add(sv.NoiSinh);
                liv.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                liv.SubItems.Add(sv.MaNganh.ToString());
                liv.SubItems.Add(sv.MaHe.ToString());
                liv.SubItems.Add(sv.TinhTrang.ToString());
                liv.SubItems.Add(sv.NienKhoa.ToString());
                liv.Tag = sv;
                lsvStudent.Items.Add(liv);
            }
        }

        private void ClearTextBox()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            txtKhoa.Text = txtHo.Text = txtNoiSinh.Text = txtTen.Text = "";
            radNam.Checked = radNu.Checked = false;
            cboNganh.SelectedIndex = cboHe.SelectedIndex = cboTinhTrang.SelectedIndex = 0;
        }

        private void lsvStudent_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            if (lsvStudent.SelectedItems.Count > 0)
            {
                ListViewItem liv = lsvStudent.SelectedItems[0];
                SinhVienDTO sv = (SinhVienDTO)liv.Tag;
                txtMaSV.Text = sv.MaSV.ToString();
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
                cboNganh.Text = sv.MaNganh;
                cboHe.Text = sv.MaHe;
                cboTinhTrang.Text = sv.TinhTrang;
                if (cboTinhTrang.SelectedValue.ToString() == "4")
                    btnXoa.Visible = true;
                else
                    btnXoa.Visible = false;
                txtKhoa.Text = sv.NienKhoa.ToString();
            }
            else
            {
                cboNganh.SelectedIndex = -1;
                cboHe.SelectedIndex = -1;
                cboTinhTrang.SelectedIndex = -1;
                txtKhoa.Text = txtHo.Text = txtNoiSinh.Text = txtTen.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHo.Text == "" || txtTen.Text == "" || cboHe.Text == "Tất cả" || cboNganh.Text == "Tất Cả" || cboTinhTrang.Text == "Tất Cả")
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            else
            {
                SinhVienDTO sv = new SinhVienDTO();
                sv.Ho = txtHo.Text;
                sv.Ten = txtTen.Text;
                if (radNam.Checked == false)
                    sv.GioiTinh = true;
                else
                    sv.GioiTinh = false;
                sv.NoiSinh = txtNoiSinh.Text;
                sv.NgaySinh = Convert.ToDateTime(dtpkNgaySinh.Text);
                sv.MaNganh = cboNganh.SelectedValue.ToString();
                sv.MaHe = cboHe.SelectedValue.ToString();
                sv.TinhTrang = cboTinhTrang.SelectedValue.ToString();
                sv.NienKhoa = Convert.ToInt32(txtKhoa.Text);
                if (SinhVienBUS.ThemSinhVien(sv))
                {
                    MessageBox.Show("Thêm thành công");
                    List<SinhVienDTO> lstSinhVien = SinhVienBUS.GetListSinhVien();
                    LoadSinhVien(lstSinhVien);
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    sv = null;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.MaSV = Convert.ToInt32(txtMaSV.Text);
            sv.Ho = txtHo.Text;
            sv.Ten = txtTen.Text;
            if (radNam.Checked == false)
                sv.GioiTinh = true;
            else
                sv.GioiTinh = false;
            sv.NoiSinh = txtNoiSinh.Text;
            sv.NgaySinh = Convert.ToDateTime(dtpkNgaySinh.Text);
            sv.MaNganh = cboNganh.SelectedValue.ToString();
            sv.MaHe = cboHe.SelectedValue.ToString();
            sv.TinhTrang = cboTinhTrang.SelectedValue.ToString();
            sv.NienKhoa = Convert.ToInt32(txtKhoa.Text);
            if (SinhVienBUS.CapNhatSinhVien(sv))
            {
                MessageBox.Show("Cập nhật thành công");
                List<SinhVienDTO> lstsinhvien = SinhVienBUS.GetListSinhVien();
                LoadSinhVien(lstsinhvien);
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<SinhVienDTO> listSV;
            if (txtHo.Text == "" && txtTen.Text == "" && txtNoiSinh.Text == "" && cboNganh.Text == "Tất Cả" && cboHe.Text == "Tất Cả" && cboTinhTrang.Text == "Tất Cả")
                listSV = SinhVienBUS.GetListSinhVien();
            else
               listSV = SinhVienBUS.TimKiemSinhVien(txtHo.Text, txtTen.Text, txtNoiSinh.Text, cboNganh.SelectedValue.ToString(), cboHe.SelectedValue.ToString(), cboTinhTrang.SelectedValue.ToString());
            LoadSinhVien(listSV);

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            List<SinhVienDTO> listSV = SinhVienBUS.GetListSinhVien();
            LoadSinhVien(listSV);
        }
    }
}
