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
    public partial class QLLopHoc : Form
    {
        public QLLopHoc()
        {
            InitializeComponent();
            btnXoa.Visible = false;
            dtpkNgayKetThuc.Visible = false;
            lblTT.Text = "Trạng Thái Lớp:";
        }

        private static QLLopHoc _Instance = null;

        public static QLLopHoc Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLLopHoc();
                return _Instance;
            }
        }
        private void QLLopHoc_Load(object sender, EventArgs e)
        {

            cboTimeLop.SelectedValue = 0;
            LoadDataVaoCbo();
           
            //
            lsvLopHoc.Items.Clear();
            List<LopHocDTO> listLop = LopHocBUS.LayDanhSachTatCaLopHoc();
            lsvLopHoc.Columns.Add("MÃ LỚP HỌC", 1);
            lsvLopHoc.Columns.Add("TÊN LỚP HỌC", 600);
            lsvLopHoc.Columns.Add("MÔN HỌC", 200);
            lsvLopHoc.Columns.Add("NGÀY BẮT ĐẦU", 200, HorizontalAlignment.Center);
            lsvLopHoc.Columns.Add("NGÀY KẾT THÚC", 200, HorizontalAlignment.Center);
            lsvLopHoc.Columns.Add("SỐ LƯỢNG", 150, HorizontalAlignment.Center);
            lsvLopHoc.Columns.Add("GIÃNG VIÊN", 150, HorizontalAlignment.Center);


            lsvLopHoc.View = View.Details;
            lsvLopHoc.GridLines = true;
            lsvLopHoc.FullRowSelect = true;

            LoadLopHoc(listLop);
            btnSua.Enabled = false;
        }

        private void LoadLopHoc(List<LopHocDTO> listLop)
        {
            lsvLopHoc.Items.Clear();
            for (int i = 0; i < listLop.Count(); i++)
            {
                LopHocDTO lop = listLop[i];
                ListViewItem liv = new ListViewItem();
                liv.Text = lop.MaLop.ToString();
                liv.SubItems.Add(lop.TenLop);
                liv.SubItems.Add(lop.MaMon.ToString());
                liv.SubItems.Add(lop.NgayBatDau.ToString("dd/MM/yyyy"));
                liv.SubItems.Add(lop.NgayKetThuc.ToString("dd/MM/yyyy"));
                liv.SubItems.Add(lop.SiSo.ToString());
                liv.SubItems.Add(lop.MaGV);
                liv.Tag = lop;
                lsvLopHoc.Items.Add(liv);
            }
        }


        private void LoadDataVaoCbo()
        {
            List<NganhDTO> listNganh = NganhBUS.LayDanhSachTatCaNganh();
            NganhDTO ALL = new NganhDTO();
            ALL.MaNganh = 0;
            ALL.TenNganh = "Tất Cả";
            ALL.TrangThai = false;
            listNganh.Insert(0, ALL);
            //
            cboMaNganh.DisplayMember = "TenNganh";
            cboMaNganh.ValueMember = "MaNganh";
            cboMaNganh.DataSource = listNganh;
            cboMaNganh.SelectedValue = 0;

            List<GiangVienDTO> listGiangVien = GiangVienBUS.LayDanhSachGiangVien();
            GiangVienDTO ALl = new GiangVienDTO();
            ALl.MaGV = 0;
            ALl.Ten = "Tất Cả";
            ALl.TinhTrang = false;
            listGiangVien.Insert(0, ALl);
            //
            cboMaGiangVien.DisplayMember = "Ten";
            cboMaGiangVien.ValueMember = "MaGV";
            cboMaGiangVien.DataSource = listGiangVien;
            cboMaGiangVien.SelectedValue = 0;

            List<MonHocDTO> listMonHoc = MonHocBUS.LayDanhSachTatCaMonHocConApDung();
            MonHocDTO aLL = new MonHocDTO();
            aLL.MaMonHoc = 0;
            aLL.TenMonHoc = "Tất Cả";
            aLL.TrangThai = false;
            listMonHoc.Insert(0, aLL);
            //
            cboMaMon.DisplayMember = "TenMonHoc";
            cboMaMon.ValueMember = "MaMonHoc";
            cboMaMon.DataSource = listMonHoc;
            cboMaMon.SelectedValue = 0;
        }

        private void lsvLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTT.Text = "Ngày Kết Thúc:";
            dtpkNgayKetThuc.Visible = true;
            cboTimeLop.Visible = false;
            if (lsvLopHoc.SelectedItems.Count > 0)
            {
                ListViewItem liv = lsvLopHoc.SelectedItems[0];
                LopHocDTO lop = (LopHocDTO)liv.Tag;
                txtMaLop.Text = lop.MaLop.ToString();
                txtTenLop.Text = lop.TenLop;
                dtpkNgayBatDau.Text = lop.NgayBatDau.ToString();
                dtpkNgayKetThuc.Text = lop.NgayKetThuc.ToString();
                //cboNganh.SelectedValue = sv.MaNganh;
                //cboHe.SelectedValue = sv.MaHe;
                cboMaMon.Text = lop.MaMon;
                txtSoLuong.Text = lop.SiSo.ToString();
                cboMaGiangVien.Text = lop.MaGV;
            }
            else
            {
                txtMaLop.Text = txtTenLop.Text = txtSoLuong.Text = "";
            }
            btnSua.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LopHocDTO lop = new LopHocDTO();
            lop.TenLop = cboMaMon.Text + "(" + dtpkNgayBatDau.Text + ")";
            lop.NgayBatDau = Convert.ToDateTime(dtpkNgayBatDau.Text);
            //lop.NgayKetThuc = Convert.ToDateTime(dtpkNgayKetThuc.Text);
            lop.NgayKetThuc = Convert.ToDateTime(dtpkNgayBatDau.Text).AddMonths(3);
            MessageBox.Show(lop.NgayKetThuc.ToString("dd/mm/yyyy"));
            lop.MaGV = cboMaGiangVien.SelectedValue.ToString();
            if (txtSoLuong.Text == "" || txtSoLuong == null)
                lop.SiSo = 0;
            else
                lop.SiSo = Convert.ToInt32(txtSoLuong.Text);
            lop.MaMon = cboMaMon.SelectedValue.ToString();
            if (/*DateTime.Compare(Convert.ToDateTime(dtpkNgayBatDau.Text), Convert.ToDateTime(dtpkNgayKetThuc.Text)) > 0 ||*/ cboMaMon.Text == "Tất Cả")
                MessageBox.Show("Thêm Thất Bại");
            else
            {
                if (LopHocBUS.MoLop(lop))
                {
                    MessageBox.Show("Thêm thành công");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    lop = null;
                }
            }
        }

       

        private void btnSua_Click(object sender, EventArgs e)
        {
            LopHocDTO lop = new LopHocDTO();
            lop.MaLop = Convert.ToInt32(txtMaLop.Text);
            lop.TenLop = cboMaMon.Text + "(" + dtpkNgayBatDau.Text + ")";
            lop.NgayBatDau = Convert.ToDateTime(dtpkNgayBatDau.Text);
            lop.NgayKetThuc = Convert.ToDateTime(dtpkNgayBatDau.Text).AddMonths(3);
            lop.MaGV = cboMaGiangVien.SelectedValue.ToString();
            if (txtSoLuong.Text == "" || txtSoLuong == null)
                lop.SiSo = 0;
            else
                lop.SiSo = Convert.ToInt32(txtSoLuong.Text);
            lop.MaMon = cboMaMon.SelectedValue.ToString();
            if (/*DateTime.Compare(Convert.ToDateTime(dtpkNgayBatDau.Text), Convert.ToDateTime(dtpkNgayKetThuc.Text)) > 0 ||*/ cboMaMon.Text == "Tất Cả")
                MessageBox.Show("Cập Nhật Thất Bại");
            else
            {
                if (LopHocBUS.CapNhatLopHoc(lop))
                {
                    MessageBox.Show("Cập Nhật thành công");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Cập Nhật thất bại");
                    lop = null;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            List<LopHocDTO> lstMonHoc = LopHocBUS.LayDanhSachTatCaLopHoc();
            LoadLopHoc(lstMonHoc);
            txtSoLuong.Text = txtTenLop.Text = txtMaLop.Text = "";
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            dtpkNgayKetThuc.Visible = false;
            lblTT.Text = "Trạng Thái Lớp:";
            cboTimeLop.Visible = true;
            LoadDataVaoCbo();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<LopHocDTO> lstLopHoc;
            if(cboMaMon.Text == "Tất Cả")
                lstLopHoc = LopHocBUS.LayDanhSachTatCaLopHoc();
            else
            {
                lstLopHoc = LopHocBUS.TimKiemLopHoc(cboMaMon.SelectedValue.ToString());
            }
            LoadLopHoc(lstLopHoc);
        }

        private void cboTimeLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<LopHocDTO> lstLopHoc;
            if (cboTimeLop.Text == "Đã Kết Thúc")
                lstLopHoc = LopHocBUS.LayDanhSachLopHocDaHocXong();
            else if (cboTimeLop.Text == "Chưa Kết Thúc")
                lstLopHoc = LopHocBUS.LayDanhSachLopHocDangHoc();
            else if (cboTimeLop.Text == "Chưa Bắt Đầu")
                lstLopHoc = LopHocBUS.LayDanhSachLopHocChuaKhaiGiang();
            else
                lstLopHoc = LopHocBUS.LayDanhSachTatCaLopHoc();
            LoadLopHoc(lstLopHoc);
        }

        private void cboMaNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MonHocDTO> lstMonHoc;
            List<GiangVienDTO> lstGiangVien;
            if (cboMaNganh.Text == "Tất Cả")
            {
                lstMonHoc = MonHocBUS.LayDanhSachTatCaMonHocConApDung();
                lstGiangVien = GiangVienBUS.LayDanhSachGiangVien();
            }
            else
            {
                lstMonHoc = MonHocBUS.LayDSMonHocTheoNganh(Convert.ToInt32(cboMaNganh.SelectedValue.ToString()));
                lstGiangVien = GiangVienBUS.LayDSGiangVienTheoNganh(Convert.ToInt32(cboMaNganh.SelectedValue.ToString()));
            }
            cboMaMon.DataSource = lstMonHoc;
            cboMaGiangVien.DataSource = lstGiangVien;
        }
    }
}
